using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<IEnumerable<Project>> GetAllProjectsAsync()
        {
            return await _projectRepository.GetProjectsWithImagesAsync();
        }

        public async Task<Project?> GetProjectByIdAsync(int id)
        {
            return await _projectRepository.GetByIdAsync(id);
        }

        public async Task CreateProjectAsync(Project project)
        {
            //Basic validation
            if(string.IsNullOrEmpty(project.Title))
                throw new Exception("Project title is required.");

            await _projectRepository.AddAsync(project);
            await _projectRepository.SaveChangesAsync();
        }

        public async Task UpdateProjectAsync(Project project)
        {
            if(!await _projectRepository.ExistsAsync(project.Id))
                throw new Exception("Project not found.");

             _projectRepository.Update(project);
            await _projectRepository.SaveChangesAsync();
        }

        public async Task DeleteProjectAsync(int id)
        {
            var project = await _projectRepository.GetByIdAsync(id);

            if(project == null)
                throw new Exception("Project not found.");

            _projectRepository.Delete(project);
            await _projectRepository.SaveChangesAsync();
        }
    }
}
