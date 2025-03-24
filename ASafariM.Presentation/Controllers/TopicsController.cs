using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace ASafariM.Presentation.Controllers
{
    /// <summary>
    /// Controller for managing topics
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TopicsController : ControllerBase
    {
        private readonly ITopicRepository _topicRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicsController"/> class
        /// </summary>
        /// <param name="topicRepository">The topic repository</param>
        /// <param name="mapper">The AutoMapper instance</param>
        public TopicsController(ITopicRepository topicRepository, IMapper mapper)
        {
            _topicRepository = topicRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Gets all topics
        /// </summary>
        /// <returns>List of topics</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TopicDto>>> GetTopics()
        {
            var topics = await _topicRepository.GetAllAsync();
            if (topics == null)
                return NotFound();
            Log.Information("Retrieved {count} topics", topics.Count());
            return Ok(_mapper.Map<IEnumerable<TopicDto>>(topics));
        }

        /// <summary>
        /// Gets a topic by ID
        /// </summary>
        /// <param name="id">The topic ID</param>
        /// <returns>The topic</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<TopicDto>> GetTopic(Guid id)
        {
            var topic = await _topicRepository.GetByIdAsync(id);
            if (topic == null)
                return NotFound();
            Log.Information("Retrieved topic with id {id}", id);
            return Ok(_mapper.Map<TopicDto>(topic));
        }

        /// <summary>
        /// Gets a topic by slug
        /// </summary>
        /// <param name="slug">The topic slug</param>
        /// <returns>The topic</returns>
        [HttpGet("slug/{slug}")]
        public async Task<ActionResult<TopicDto>> GetTopicBySlug(string slug)
        {
            var topic = await _topicRepository.GetBySlugAsync(slug);
            if (topic == null)
                return NotFound();
            Log.Information("Retrieved topic with slug {slug}", slug);
            return Ok(_mapper.Map<TopicDto>(topic));
        }

        /// <summary>
        /// Gets child topics for a parent topic
        /// </summary>
        /// <param name="id">The parent topic ID</param>
        /// <returns>List of child topics</returns>
        [HttpGet("{id}/children")]
        public async Task<ActionResult<IEnumerable<TopicDto>>> GetChildTopics(Guid id)
        {
            var topics = await _topicRepository.GetChildTopicsAsync(id);
            if (topics == null)
                return NotFound();
            Log.Information("Retrieved child topics for topic with id {id}", id);
            return Ok(_mapper.Map<IEnumerable<TopicDto>>(topics));
        }

        /// <summary>
        /// Creates a new topic
        /// </summary>
        /// <param name="command">The topic creation command</param>
        /// <returns>The created topic</returns>
        [HttpPost]
        public async Task<ActionResult<TopicDto>> CreateTopic(CreateTopicCommand command)
        {
            if (await _topicRepository.SlugExistsAsync(command.Slug))
                return BadRequest("Slug already exists");

            var topic = _mapper.Map<Topic>(command);
            topic.Slug = command.Slug.ToLower();
            await _topicRepository.AddAsync(topic);
            await _topicRepository.SaveChangesAsync();
            Log.Information("Created topic with id {id}", topic.Id);
            Log.Information("Created topic with slug {slug}", topic.Slug);
            Log.Information("Created topic with name {name}", topic.Name);
            Log.Information("Created topic with description {description}", topic.Description);
            Log.Information(
                "Created topic with parent topic id {parentTopicId}",
                topic.ParentTopicId
            );
            return CreatedAtAction(
                nameof(GetTopic),
                new { id = topic.Id },
                _mapper.Map<TopicDto>(topic)
            );
        }

        /// <summary>
        /// Updates an existing topic
        /// </summary>
        /// <param name="id">The topic ID</param>
        /// <param name="command">The topic update command</param>
        /// <returns>The updated topic</returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<TopicDto>> UpdateTopic(Guid id, UpdateTopicCommand command)
        {
            if (id != command.Id)
            {
                Log.Error("Invalid topic id");
                return BadRequest();
            }

            var existingTopic = await _topicRepository.GetByIdAsync(id);
            if (existingTopic == null)
            {
                Log.Error("Topic not found");
                return NotFound();
            }

            if (
                command.Slug != existingTopic.Slug
                && await _topicRepository.SlugExistsAsync(command.Slug)
            )
            {
                Log.Error("Slug already exists");
                return BadRequest("Slug already exists");
            }

            _mapper.Map(command, existingTopic);
            await _topicRepository.UpdateAsync(existingTopic);
            Log.Information("Updated topic with id {id}", id);
            return Ok(_mapper.Map<TopicDto>(existingTopic));
        }

        /// <summary>
        /// Deletes a topic
        /// </summary>
        /// <param name="id">The topic ID</param>
        /// <returns>No content if successful</returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTopic(Guid id)
        {
            try
            {
                var topic = await _topicRepository.GetByIdAsync(id);
                if (topic == null)
                {
                    Log.Error("Topic not found for deletion with id {id}", id);
                    return NotFound("Topic not found");
                }

                if (await _topicRepository.HasChildrenAsync(id))
                {
                    Log.Error("Topic with id {id} has children, cannot delete", id);
                    return BadRequest(
                        "This topic has subtopics and cannot be deleted. Please remove or reassign the subtopics first."
                    );
                }

                await _topicRepository.DeleteAsync(id);
                Log.Information("Deleted topic with id {id}", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "An error occurred while deleting topic with id {id}. Error: {Error}",
                    id,
                    ex.Message
                );
                return StatusCode(500, $"An error occurred while deleting the topic: {ex.Message}");
            }
        }
    }
}
