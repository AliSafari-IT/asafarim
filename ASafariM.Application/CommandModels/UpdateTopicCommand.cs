namespace ASafariM.Application.CommandModels
{
    public class UpdateTopicCommand : CreateTopicCommand
    {
        public Guid Id { get; set; }
        public new string Name { get; set; } // Fix: Add 'new'
        public new string? Description { get; set; } // Fix: Add 'new'
        public new string Slug { get; set; } // Fix: Add 'new'
        public new Guid? ParentTopicId { get; set; } // Fix: Add 'new'
    }
}
