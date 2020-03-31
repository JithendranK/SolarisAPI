using ProjectManager.Models;
using System.Collections.Generic;

namespace ProjectManager.DataAccess.Interfaces
{
    public interface IProjectDataAccess
    {
        void CreateProject(Project project);
        void GetProject();
        IEnumerable<Project> GetProjects();
        IEnumerable<Indication> GetIndications();
        IEnumerable<Currency> GetCurrency();
        IEnumerable<ProjectTimeUnit> GetTimeUnits();
        IEnumerable<Program> GetPrograms();
        void EditProject();
        void CreateProgram();
    }
}
