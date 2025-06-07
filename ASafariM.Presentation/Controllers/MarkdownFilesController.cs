using ASafariM.Application.DTOs;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace ASafariM.Presentation.Controllers;

/// <summary>
/// Provides access to markdown files.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class MarkdownFilesController : ControllerBase
{
    private readonly IMarkdownFilesService _markdownFilesService;
    private readonly IMapper _mapper;

    public MarkdownFilesController(IMarkdownFilesService markdownFilesService, IMapper mapper)
    {
        _markdownFilesService =
            markdownFilesService ?? throw new ArgumentNullException(nameof(markdownFilesService));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    /// <summary>
    /// Retrieves all markdown files.
    /// </summary>
    /// <returns>Collection of markdown files</returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<MarkdownFileResponseDto>>> GetAllMarkdownFiles()
    {
        try
        {
            Log.Information("Fetching all markdown files");
            var markdownFiles = await _markdownFilesService.GetAllMarkdownFiles();
            Log.Information(
                "Successfully retrieved {FileCount} markdown files",
                markdownFiles?.Count() ?? 0
            );
            var response = _mapper.Map<IEnumerable<MarkdownFileResponseDto>>(markdownFiles);
            return Ok(response);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while fetching all markdown files");
            return StatusCode(500, "An error occurred while retrieving markdown files");
        }
    }

    /// <summary>
    /// Retrieves a markdown file by ID.
    /// </summary>
    /// <param name="id">ID of the markdown file</param>
    /// <returns>Markdown file</returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<MarkdownFileResponseDto>> GetMarkdownFileById(Guid id)
    {
        try
        {
            Log.Information("Fetching markdown file with ID: {FileId}", id);
            var markdownFile = await _markdownFilesService.GetMarkdownFileById(id);
            if (markdownFile == null)
            {
                Log.Warning("Markdown file not found with ID: {FileId}", id);
                return NotFound();
            }

            Log.Information("Successfully retrieved markdown file with ID: {FileId}", id);
            var response = _mapper.Map<MarkdownFileResponseDto>(markdownFile);
            return Ok(response);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while fetching markdown file with ID: {FileId}", id);
            return StatusCode(500, "An error occurred while retrieving the markdown file");
        }
    }

    /// <summary>
    /// Creates a new markdown file.
    /// </summary>
    /// <param name="createDto">Create markdown file request</param>
    /// <returns>Created markdown file</returns>
    [HttpPost]
    public async Task<ActionResult<MarkdownFileResponseDto>> CreateMarkdownFile(
        [FromBody] CreateMarkdownFileDto createDto
    )
    {
        try
        {
            Log.Information("Creating new markdown file with title: {Title}", createDto.Title);

            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == "sub")?.Value;
            if (string.IsNullOrEmpty(userIdClaim) || !Guid.TryParse(userIdClaim, out var userId))
            {
                Log.Warning(
                    "Unauthorized attempt to create markdown file. User ID not found in token claims"
                );
                return Unauthorized("User ID not found in token claims");
            }

            var markdownFile = _mapper.Map<MarkdownFile>(createDto);
            var createdMarkdownFile = await _markdownFilesService.CreateMarkdownFile(
                markdownFile,
                userId
            );

            Log.Information(
                "Successfully created markdown file with ID: {FileId} by user: {UserId}",
                createdMarkdownFile.Id,
                userId
            );
            var response = _mapper.Map<MarkdownFileResponseDto>(createdMarkdownFile);
            return CreatedAtAction(nameof(GetMarkdownFileById), new { id = response.Id }, response);
        }
        catch (Exception ex)
        {
            Log.Error(
                ex,
                "Error occurred while creating markdown file with title: {Title}",
                createDto.Title
            );
            return StatusCode(500, "An error occurred while creating the markdown file");
        }
    }

    /// <summary>
    /// Updates an existing markdown file.
    /// </summary>
    /// <param name="id">ID of the markdown file to update</param>
    /// <param name="updateDto">Update markdown file request</param>
    /// <returns>Updated markdown file</returns>
    [HttpPut("{id}")]
    public async Task<ActionResult<MarkdownFileResponseDto>> UpdateMarkdownFile(
        Guid id,
        [FromBody] CreateMarkdownFileDto updateDto
    )
    {
        try
        {
            Log.Information("Updating markdown file with ID: {FileId}", id);

            var existingFile = await _markdownFilesService.GetMarkdownFileById(id);
            if (existingFile == null)
            {
                Log.Warning("Markdown file not found for update with ID: {FileId}", id);
                return NotFound();
            }

            _mapper.Map(updateDto, existingFile);
            var updatedMarkdownFile = await _markdownFilesService.UpdateMarkdownFile(existingFile);
            Log.Information("Successfully updated markdown file with ID: {FileId}", id);
            var response = _mapper.Map<MarkdownFileResponseDto>(updatedMarkdownFile);
            return Ok(response);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while updating markdown file with ID: {FileId}", id);
            return StatusCode(500, "An error occurred while updating the markdown file");
        }
    }

    /// <summary>
    /// Deletes a markdown file by ID.
    /// </summary>
    /// <param name="id">ID of the markdown file to delete</param>
    /// <returns>Response indicating success or failure</returns>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMarkdownFile(Guid id)
    {
        try
        {
            Log.Information("Deleting markdown file with ID: {FileId}", id);

            var markdownFile = await _markdownFilesService.GetMarkdownFileById(id);
            if (markdownFile == null)
            {
                Log.Warning("Markdown file not found for deletion with ID: {FileId}", id);
                return NotFound();
            }

            await _markdownFilesService.DeleteMarkdownFile(id);
            Log.Information("Successfully deleted markdown file with ID: {FileId}", id);
            return NoContent();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while deleting markdown file with ID: {FileId}", id);
            return StatusCode(500, "An error occurred while deleting the markdown file");
        }
    }

    /// <summary>
    /// Deletes multiple markdown files by IDs.
    /// </summary>
    /// <param name="ids">Collection of IDs of markdown files to delete</param>
    /// <returns>Response indicating success or failure</returns>
    [HttpDelete]
    [Route("delete-many")]
    public async Task<IActionResult> DeleteMarkdownFiles([FromBody] IEnumerable<Guid> ids)
    {
        try
        {
            Log.Information(
                "Deleting multiple markdown files. Count: {FileCount}",
                ids?.Count() ?? 0
            );

            foreach (var id in ids)
            {
                try
                {
                    var markdownFile = await _markdownFilesService.GetMarkdownFileById(id);
                    if (markdownFile == null)
                    {
                        Log.Warning("Markdown file not found for deletion with ID: {FileId}", id);
                        continue;
                    }

                    await _markdownFilesService.DeleteMarkdownFile(id);
                    Log.Information("Successfully deleted markdown file with ID: {FileId}", id);
                }
                catch (Exception ex)
                {
                    Log.Error(
                        ex,
                        "Error deleting markdown file with ID: {FileId}. Continuing with remaining files.",
                        id
                    );
                }
            }

            return NoContent();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while batch deleting markdown files");
            return StatusCode(500, "An error occurred while deleting the markdown files");
        }
    }
}
