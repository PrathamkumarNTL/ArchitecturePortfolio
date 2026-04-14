namespace Application.DTOs.Projects
{
    public class ProjectResponseDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTime CompletetionDate { get; set; }
        public List<string> ImageUrls { get; set; } = new();
    }
}
