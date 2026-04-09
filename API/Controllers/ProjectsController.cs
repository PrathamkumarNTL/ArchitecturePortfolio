
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        // GET: api/projects
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var projects = await _projectService.GetAllProjectsAsync();
            return Ok(projects);
        }

        // GET: api/projects/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var project = await _projectService.GetProjectByIdAsync(id);
            if (project == null)
                return NotFound();
            return Ok(project);
        }

        // POST: api/projects
        [HttpPost]
        public async Task<IActionResult> Create(Project project)
        {
            await _projectService.CreateProjectAsync(project);
            return Ok("Projected created successfully");
        }

        // PUT: api/projects
        [HttpPut]
        public async Task<IActionResult> Update(Project project)
        {
            await _projectService.UpdateProjectAsync(project);
            return Ok("Projected updated successfully");
        }

        // DELETE: api/projects/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _projectService.DeleteProjectAsync(id);
            return Ok("Projected deleted successfully");
        }
    }
}
