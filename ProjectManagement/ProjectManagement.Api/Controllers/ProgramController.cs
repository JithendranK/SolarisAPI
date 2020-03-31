using Microsoft.AspNetCore.Mvc;
using ProjectManager.Services.Interfaces;
using System.Collections.Generic;

namespace ProjectManager.Api.Controllers
{
    /// <summary>
    /// Controller created for performaing GET/POST actions on Program resource
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/v{v:apiVersion}")]
    [ApiController]
    public class ProgramController : ControllerBase
    {
        private readonly IProjectService projectService;
        public ProgramController(IProjectService projectService)
        {
            this.projectService = projectService;

        }

        /// <summary>
        /// Get endpoint created for listing programs
        /// </summary>
        /// <returns></returns>
        [Route("programs")]
        public ActionResult<IEnumerable<ProjectManager.Models.Program>> GetPrograms()
        {
            IEnumerable<ProjectManager.Models.Program> programs = projectService.GetPrograms();
            return Ok(programs);
        }

    }
}