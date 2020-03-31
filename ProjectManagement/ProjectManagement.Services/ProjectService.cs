using Microsoft.Extensions.Options;
using ProjectManager.DataAccess;
using ProjectManager.DataAccess.Interfaces;
using ProjectManager.Models;
using ProjectManager.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace ProjectManager.Services
{
    public class ProjectService: IProjectService
    {
        private readonly IProjectDataAccess projectDataAccess;
        public ProjectService(IOptions<ProjectManagerSettings> settings)
        {
             projectDataAccess = new ProjectDataAccess(settings.Value.ConnectionString);
        }
        public void CreateProject(Project project)
        {
            throw new NotImplementedException();
        }
        public void GetProject()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> GetProjects()
        {
            IEnumerable<Project> projects = projectDataAccess.GetProjects();

            return projects;
        }
        public IEnumerable<Program> GetPrograms()
        {
            IEnumerable<Program> programs = projectDataAccess.GetPrograms();
            return programs;
        }
        public IEnumerable<Indication> GetIndications()
        {
            IEnumerable<Indication> indications = projectDataAccess.GetIndications();

            return indications;
        }
        public IEnumerable<Currency> GetCurrency()
        {
            IEnumerable<Currency> currencies = projectDataAccess.GetCurrency();

            return currencies;
        }
        public IEnumerable<ProjectTimeUnit> GetTimeUnits()
        {
            IEnumerable<ProjectTimeUnit> timeUnits = projectDataAccess.GetTimeUnits();

            return timeUnits;
        }
        public void EditProject()
        {
            throw new NotImplementedException();
        }
        public void CreateProgram()
        {
            throw new NotImplementedException();
        }
      
    }
}
