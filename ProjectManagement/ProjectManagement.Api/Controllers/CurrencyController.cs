using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using ProjectManager.Models;
using ProjectManager.Services.Interfaces;

namespace ProjectManagement.Api.Controllers
{
    /// <summary>
    /// Controller created for performing GET action on Currency resource
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/v{v:apiVersion}")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly IProjectService projectService;
        public CurrencyController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        /// <summary>
        /// GET endpoint created for getting the list of currencies.
        /// </summary>
        /// <returns></returns>
        [Route("currencies")]
        public ActionResult GetCurrency()
        {
            IEnumerable<Currency> currencies = projectService.GetCurrency();
            return Ok(currencies);
        }
    }
}
