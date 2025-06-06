using System;

namespace ASafariM.Application.CommandModels
{
    public class CreateTopicCommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public Guid? ParentTopicId { get; set; }
    }
}
