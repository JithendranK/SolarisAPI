using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using ProjectManager.Api.Enums;
using ProjectManager.Models;
using ProjectManager.Services.Interfaces;
using System.Collections.Generic;
using System.Resources;

namespace ProjectManager.Api.Controllers
{
    /// <summary>
    /// Project Controller for performing get, post actions on Project resource 
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/v{v:apiVersion}")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService projectService;
        private readonly IStringLocalizer<ProjectController> projectServicelocalizer;
        public ProjectController(IProjectService projectService, IStringLocalizer<ProjectController> projectServicelocalizer)
        {
            this.projectService = projectService;
            this.projectServicelocalizer = projectServicelocalizer;
        }
        /// <summary>
        /// Get endpoint for listing the projects
        /// </summary>
        /// <returns></returns>
        [Route("projects")]
        public ActionResult<IEnumerable<Project>> GetProjects()
        {
            IEnumerable<Project> projects = projectService.GetProjects();
            return Ok(projects);
        }

        /// <summary>
        /// POST endpoint for creating projects
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        [Route("projects")]
        [HttpPost]
        public ActionResult CreateProject(Project project)
        {
            return Ok(project);
        }


    }
}