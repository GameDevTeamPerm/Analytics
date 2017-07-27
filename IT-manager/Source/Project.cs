using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_manager
{
    public class Project
    {
        public double Budget { get; set; }
        /// <summary>
        /// Количество прошеших дней
        /// </summary>
        public int PassedDays
        {
            get
            {
                return passedDays;
            }
        }
        private int passedDays;
        public int Iteration
        { 
            get 
        {
                return iteration; 
            } 
        }
        private int iteration;

        public string ProjectDescription { get; set; }
        public string ProjectTask { get; set; }
        public List<Stakeholder> Stakeholders { get; set; }
        public List<Requirement> Requirements { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Test> Tests { get; set; }

        public Project(double budget, Content content)
        {
            Budget = budget;
            passedDays = 0;
            iteration = 1;
            ProjectDescription = content.ProjectDescription;
            ProjectTask = content.ProjectTask;
            Stakeholders = content.Stakeholders.GetRange(0, content.Stakeholders.Count); ;
            Requirements = content.Requirements.GetRange(0, content.Requirements.Count);
            Employees = content.Employees.GetRange(0, content.Employees.Count);
            Tests = content.Tests.GetRange(0, content.Tests.Count);
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            if (Employees.Contains(employee))
            {
                Employees.Remove(employee);
            }
        }

        public void IncrementDay()
        {
            passedDays++;
        }

        public void IncrementIteration()
        {
            iteration++;
        }
    }
}
