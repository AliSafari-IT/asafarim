using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Application.Interfaces;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Enums;
using ASafariM.Domain.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace ASafariM.Presentation.Controllers
{
    /// <summary>
    /// Provides access to posts.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        private readonly ITagRepository _tagRepository;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private string CurrentUserId =>
            User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

        public PostsController(
            IPostRepository postRepository,
            ITagRepository tagRepository,
            IMapper mapper,
            IUserService userService
        )
        {
            _postRepository = postRepository;
            _tagRepository = tagRepository;
            _mapper = mapper;
            _userService = userService;
        }

        private bool IsAdmin =>
            User.IsInRole(RoleEnum.Admin.ToString())
            || User.IsInRole(RoleEnum.SuperAdmin.ToString());
        private bool IsModerator => User.IsInRole(RoleEnum.Moderator.ToString());
        private bool IsEditor => User.IsInRole(RoleEnum.Editor.ToString());
        private bool IsSuperAdmin => User.IsInRole(RoleEnum.SuperAdmin.ToString());
        private bool IsGuest => User.IsInRole(RoleEnum.Guest.ToString());
        private bool IsUser => User.IsInRole(RoleEnum.User.ToString());

        /// <summary>
        /// Creates a new post.
        /// </summary>
        /// <param name="command">Create post command</param>
        /// <returns>Created post</returns>
        [Authorize(Roles = "Admin,SuperAdmin,Editor,Moderator,User")]
        [HttpPost("create")]
        public async Task<ActionResult<PostDto>> CreatePost([FromBody] CreatePostCommand command)
        {
            Log.Information("Received request to create post: /api/posts/create");
            Log.Information("User Claims: {@Claims}", User.Claims);

            // Log CurrentUserId as a debug log entry for Authorization and to log the command received for debugging purposes
            Log.Information("CurrentUserId: {CurrentUserId}", CurrentUserId);
            Log.Information("Command before processing: {@Command}", command);
            try
            {
                if (
                    string.IsNullOrWhiteSpace(command?.Title)
                    || string.IsNullOrWhiteSpace(command?.Content)
                )
                {
                    Log.Warning("Validation failed: Title or Content is missing");
                    return BadRequest("Title and Content are required.");
                }

                if (string.IsNullOrEmpty(command?.Slug))
                {
                    Log.Warning("Slug is null or empty");
                    return BadRequest("Slug is required.");
                }

                if (await _postRepository.SlugExistsAsync(command.Slug))
                {
                    Log.Warning("Slug already exists: {Slug}", command.Slug);
                    return BadRequest("Slug already exists.");
                }

                if (string.IsNullOrEmpty(CurrentUserId))
                {
                    Log.Warning("CurrentUserId is null or empty.");
                    return BadRequest("User ID is required.3");
                }
                var post = _mapper.Map<Post>(command);
                post.CreatedBy = CurrentUserId;
                post.CreatedAt = DateTime.UtcNow;
                post.AuthorId = Guid.Parse(CurrentUserId);

                await _postRepository.AddAsync(post);
                Log.Information("Successfully created post with ID: {PostId}", post.Id);
                return CreatedAtAction(
                    nameof(GetPost),
                    new { id = post.Id },
                    _mapper.Map<PostDto>(post)
                );
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while creating post with slug: {Slug}", command.Slug);
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        /// <summary>
        /// Retrieves a post by ID.
        /// </summary>
        /// <param name="id">ID of the post to retrieve</param>
        /// <returns>Post details</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<PostDto>> GetPost(Guid id)
        {
            Log.Information("Received request to get post with ID: {PostId}", id);
            try
            {
                var post = await _postRepository.GetByIdAsync(id);
                if (post == null)
                {
                    Log.Warning("Post not found with ID: {PostId}", id);
                    return NotFound();
                }

                Log.Information("Successfully retrieved post with ID: {PostId}", id);
                return Ok(_mapper.Map<PostDto>(post));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while fetching post with ID: {PostId}", id);
                return StatusCode(500, "An error occurred while retrieving the post");
            }
        }

        /// <summary>
        /// Retrieves all posts.
        /// </summary>
        /// <returns>Collection of posts</returns>
        [Authorize(Roles = "Admin,SuperAdmin,Editor,Moderator,User")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostDto>>> GetPosts()
        {
            try
            {
                Log.Information("Fetching all posts");
                var posts = await _postRepository.GetAllAsync();
                Log.Information("Successfully retrieved {PostCount} posts", posts?.Count() ?? 0);
                return Ok(_mapper.Map<IEnumerable<PostDto>>(posts));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while fetching all posts");
                return StatusCode(500, "An error occurred while retrieving posts");
            }
        }
    }
}
