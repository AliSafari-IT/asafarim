using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ASafariM.Infrastructure.Services
{
    public class MarkdownFilesService : IMarkdownFilesService
    {
        private readonly IGenericRepository<MarkdownFile> _markdownFileRepository;
        private readonly AppDbContext _context;

        public MarkdownFilesService(
            IGenericRepository<MarkdownFile> markdownFileRepository,
            AppDbContext context
        )
        {
            _markdownFileRepository = markdownFileRepository;
            _context = context;
        }

        // Get all markdown files
        public async Task<IEnumerable<MarkdownFile>> GetAllMarkdownFiles()
        {
            return await _markdownFileRepository.GetAllAsync();
        }

        // Get markdown file by id
        public async Task<MarkdownFile> GetMarkdownFileById(Guid id)
        {
            return await _markdownFileRepository.GetByIdAsync(id);
        }

        // Create a new markdown file
        public async Task<MarkdownFile> CreateMarkdownFile(MarkdownFile markdownFile, Guid userId)
        {
            var createdFile = await _markdownFileRepository.AddAsync(markdownFile);

            var markdownFileUser = new MarkdownFileUser
            {
                MarkdownFileId = createdFile.Id,
                UserId = userId,
            };

            await _context.MarkdownFileUsers.AddAsync(markdownFileUser);
            await _context.SaveChangesAsync();

            return createdFile;
        }

        // Update an existing markdown file
        public async Task<MarkdownFile> UpdateMarkdownFile(MarkdownFile markdownFile)
        {
            return await _markdownFileRepository.UpdateAsync(markdownFile);
        }

        // Delete an existing markdown file
        public async Task DeleteMarkdownFile(Guid id)
        {
            var markdownFile = await _markdownFileRepository.GetByIdAsync(id);
            if (markdownFile != null)
            {
                await _markdownFileRepository.DeleteAsync(markdownFile.Id);
            }
        }

        // Delete many existing markdown files
        public async Task DeleteMarkdownFiles(IEnumerable<Guid> ids)
        {
            await _markdownFileRepository.DeleteManyAsync(ids);
        }
    }
}
