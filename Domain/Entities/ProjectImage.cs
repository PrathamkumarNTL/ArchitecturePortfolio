namespace Domain.Entities
{
    public class ProjectImage : BaseEntity
    {
        public int ProjectId { get; set; }
        public string ImageUrl { get; set; } = string.Empty;

        //Navigation property
        public Project Project { get; set; }
    }
}
