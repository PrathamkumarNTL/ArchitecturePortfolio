using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ProjectRepository : GenericRepository<Project>,IProjectRepository
    {
        public ProjectRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Project>> GetProjectsWithImagesAsync()
        {
            return await _context.Projects.Include(p => p.Images).ToListAsync();
        }
    }
}
