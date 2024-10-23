using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Core.Domain.Entities;

namespace Core.Domain.Entities;

public class Tag
{
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string? Title { get; set; }

    public List<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();
}

