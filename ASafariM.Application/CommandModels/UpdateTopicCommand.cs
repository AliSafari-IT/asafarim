namespace ASafariM.Application.CommandModels
{
    public class UpdateTopicCommand : CreateTopicCommand
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Slug { get; set; }
        public Guid? ParentTopicId { get; set; }
    }
}
