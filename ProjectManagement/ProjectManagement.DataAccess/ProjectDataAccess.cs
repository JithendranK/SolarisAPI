using ProjectManager.DataAccess.Factory;
using ProjectManager.DataAccess.Interfaces;
using ProjectManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ProjectManager.DataAccess
{
    public class ProjectDataAccess : IProjectDataAccess
    {
        private readonly IProjectDBManager projectDBManager;
        public ProjectDataAccess(string connectionString)
        {
            projectDBManager = new ProjectDBManager(connectionString);
        }
       
        public void GetProject()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Project> GetProjects()
        {
            DataTable dtProject = projectDBManager.GetDataTable("SELECT * FROM project.get_project_list()", CommandType.Text);
            List<Project> projects = dtProject.AsEnumerable()
                                  .Select(x => new Project()
                                  {
                                      ID = x.Field<int>("id"),
                                      Name = x.Field<string>("name")
                                  }).ToList();
            return projects;
        }
        public IEnumerable<Indication> GetIndications()
        {
            DataTable dtIndication = projectDBManager.GetDataTable("SELECT * FROM project.get_indication_list()", CommandType.Text);
            List<Indication> indications = dtIndication.AsEnumerable()
                                  .Select(x => new Indication()
                                  {
                                      ID = x.Field<Int16>("id"),
                                      Value = x.Field<string>("value")
                                  }).ToList();
            return indications;
        }
        public IEnumerable<Currency> GetCurrency()
        {
            DataTable dtCurrency = projectDBManager.GetDataTable("SELECT * FROM project.get_currency_list()", CommandType.Text);
            List<Currency> currencies = dtCurrency.AsEnumerable()
                                  .Select(x => new Currency()
                                  {
                                      ID = x.Field<int>("id"),
                                      Value = x.Field<string>("value")
                                  }).ToList();
            return currencies;
        }
        public IEnumerable<ProjectTimeUnit> GetTimeUnits()
        {
            DataTable dtProject = projectDBManager.GetDataTable("SELECT * FROM project.get_timeunit_list()", CommandType.Text);
            List<ProjectTimeUnit> projectTimeUnits = dtProject.AsEnumerable()
                                  .Select(x => new ProjectTimeUnit()
                                  {
                                      ID = x.Field<Int16>("id"),
                                      Value = x.Field<string>("value")
                                  }).ToList();
            return projectTimeUnits;
        }
        public IEnumerable<Program> GetPrograms()
        {
            DataTable dtProject = projectDBManager.GetDataTable("SELECT * FROM project.get_program_list()", CommandType.Text);
            List<Program> programs = dtProject.AsEnumerable()
                                  .Select(x => new Program()
                                  {
                                      ID = x.Field<int>("id"),
                                      Name = x.Field<string>("name")
                                  }).ToList();
            return programs;
        }
        public void CreateProject(Project project)
        {
            throw new NotImplementedException();
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
