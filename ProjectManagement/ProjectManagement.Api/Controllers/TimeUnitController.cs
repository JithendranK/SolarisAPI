using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManager.Models;
using ProjectManager.Services.Interfaces;

namespace ProjectManager.Api.Controllers
{
    /// <summary>
    /// TimeUnit Controller for Getting TimeUnit Details
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/v{v:apiVersion}")]
    [ApiController]
    public class TimeUnitController : ControllerBase
    {
        private readonly IProjectService projectService;
        public TimeUnitController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        /// <summary>
        /// Get Endpoint created for listing currency list
        /// </summary>
        /// <returns></returns>
        [Route("projecttimeunits")]
        public ActionResult GetCurrency()
        {
            IEnumerable<ProjectTimeUnit> timeUnits = projectService.GetTimeUnits();
            return Ok(timeUnits);
        }
    }
}