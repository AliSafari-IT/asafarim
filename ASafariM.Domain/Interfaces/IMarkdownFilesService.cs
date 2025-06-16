using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;

namespace ASafariM.Domain.Interfaces
{
    public interface IMarkdownFilesService
    {
        Task<IEnumerable<MarkdownFile>> GetAllMarkdownFiles();
        Task<MarkdownFile> GetMarkdownFileById(Guid id);
        Task<MarkdownFile> CreateMarkdownFile(MarkdownFile markdownFile, Guid userId);
        Task<MarkdownFile> UpdateMarkdownFile(MarkdownFile markdownFile);
        Task DeleteMarkdownFile(Guid id);
        Task DeleteMarkdownFiles(IEnumerable<Guid> ids);
    }
}
