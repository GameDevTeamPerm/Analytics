using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_manager
{
    public class Project
    {
        public Project(double budget, List<Employee> employees, Content content)
        {
            Budget = budget;
            Employees = employees;
            Content = content;
            passedDays = 0;
            iteration = 1;

            Jobs = new List<Job>();
            Tests = new List<Test>();

            foreach (Test t in content.Tests)
            {
                Tests.Add(t);
            }
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

        private List<TreeNode> FindingKnownRequirements(List<Requirement> requirements)
        {
            List<TreeNode> resultTreeNodes = new List<TreeNode>();

            foreach (Requirement requirement in requirements)
            {
                if (requirement.IsFound)
                {
                    TreeNode tempTreeNode = new TreeNode(requirement.Name);
                    List<TreeNode> tempTreeNodes = FindingKnownRequirements(requirement.SubRequirements);

                    foreach (TreeNode treeNode in tempTreeNodes)
                    {
                        tempTreeNode.Nodes.Add(treeNode);
                    }

                    resultTreeNodes.Add(tempTreeNode);
                }
            }
            return resultTreeNodes;
        }

        public double Budget { get; set; }
        public List<Employee> Employees { get; set; }

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
        public int Iteration
        { 
            get 
        {
                return iteration; 
            } 
        }

        public List<TreeNode> KnownRequirements
        {
            get
            {
                return FindingKnownRequirements(Content.Requirements);
            }
        }

        public List<Job> Jobs { get; set; }
        public List<Test> Tests { get; set; }

        public Content Content { get; set; }

        /// <summary>
        /// Общее количество требований заложенных заказчиком
        /// </summary>
        public int RequirementsCount
        { 
            get 
            { 
                return Content.Requirements.Count; 
            } 
        }

        private int passedDays;
        private int iteration;
    }
}
