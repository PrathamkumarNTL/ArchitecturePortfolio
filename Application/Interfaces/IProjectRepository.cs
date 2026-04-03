using Domain.Entities;

namespace Application.Interfaces
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        Task<IEnumerable<Project>> GetProjectsWithImagesAsync();
    }
}
