// apps/DashboardApi/Core/Domain/Entities/Tag.cs
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashboardApi.Core.Domain.Entities;

public class Tag
{
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string? Title { get; set; }

    public List<BlogPost>? BlogPosts { get; set; } = new List<BlogPost>();
    public List<BlogPostTag> BlogPostTags { get; set; } = new List<BlogPostTag>();


    public Tag()
    {
        Id = Guid.NewGuid();
    }
}

