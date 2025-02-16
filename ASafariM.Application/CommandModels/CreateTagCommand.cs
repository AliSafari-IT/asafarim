using System;

namespace ASafariM.Application.CommandModels
{
    public class CreateTagCommand
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Slug { get; set; }
    }
}
