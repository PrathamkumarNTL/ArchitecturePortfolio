namespace Domain.Entities
{
    public class Project : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Categorcy { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;    
        public DateTime CompletetionDate { get; set; }

        //Navigation property
        public ICollection<ProjectImage> Images { get; set; }
    }
}
