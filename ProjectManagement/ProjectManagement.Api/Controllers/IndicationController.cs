using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using ProjectManager.Models;
using ProjectManager.Services.Interfaces;

namespace ProjectManager.Api.Controllers
{
    /// <summary>
    /// Controller created for performing GET action on Indication resource
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/v{v:apiVersion}")]
    [ApiController]
    public class IndicationController : ControllerBase
    {

        private readonly IProjectService projectService;
        private readonly IStringLocalizer<ProjectController> projectServicelocalizer;
        public IndicationController(IProjectService projectService, IStringLocalizer<ProjectController> projectServicelocalizer)
        {
            this.projectService = projectService;
            this.projectServicelocalizer = projectServicelocalizer;
        }

        /// <summary>
        /// Get End point created for listing indications
        /// </summary>
        /// <returns></returns>
        [Route("indications")]
        public ActionResult GetIndications()
        {
            IEnumerable<Indication> indications = projectService.GetIndications();
            return Ok(indications);
        }
    }
}