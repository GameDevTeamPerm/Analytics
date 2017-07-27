using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_manager
{
    public class ItManager
    {
        private Project Project;

        /// <summary>
        /// Количество прошеших дней
        /// </summary>
        public int PassedDays
        {
            get
            {
                return Project.PassedDays;
            }
        }
        public List<Stakeholder> Stakeholders
        {
            get
            {
                return Project.Stakeholders;
            }
        }
        public List<Employee> Employees
        {
            get
            {
                return Project.Employees;
            }
        }
        public List<Employee> HiredEmployees
        {
            get
            {
                return Project.Employees.Where(x => x.isHired).ToList();
            }
        }
        public List<TreeNode> GetTreeNodeOfKnownRequirements
        {
            get
            {
                return FindingKnownRequirements(Project.Requirements);
            }
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
        public List<Requirement> Requirements
        {
            get
            {
                return Project.Requirements;
            }
            set
            {
                Project.Requirements = value;
            }
        }
        public List<Module> Jobs
        {
            get
            {
                List<Module> jobs = new List<Module>();
                foreach (Requirement req in Project.Requirements)
                    jobs.AddRange(req.AllSubModules.Where(x => x.Developer != null || x.Tester != null));
                return jobs.Distinct().ToList();
            }
        }
        public List<Test> Tests
        {
            get
            {
                return Project.Tests;
            }
        }

        public void StartGame(Content content)
        {
            Project = new Project(2000, content);
        }

        public void HireEmployee(Employee employee)
        {
            Project.AddEmployee(employee);
        }
        public void FireEmployee(Employee employee)
        {
            Project.RemoveEmployee(employee);
        }
        public void SendToStakeholder(List<Employee> sendingEmployees, string stakeholder)
        {
            List<Employee> sortedEmployes = sendingEmployees.OrderBy(x => x.AnalystSkill).ToList();

            SearchingRequirements(sortedEmployes, Project.Requirements, stakeholder);
            foreach (Employee emp in sortedEmployes)
            {
                emp.ClearCurrentCapacity();
            }

            Project.IncrementDay();
        }
        private void SearchingRequirements(List<Employee> employees, List<Requirement> reqElems, string stakeholder)
        {
            foreach (Requirement elem in reqElems)
            {
                if (elem.IsFound || elem.Stakeholder.Name == stakeholder)
                {
                    if (elem.IsFound)
                    {
                        SearchingRequirements(employees, elem.SubRequirements, stakeholder);
                    }
                    else
                    {
                        foreach (Employee emp in employees)
                        {
                            //Если скилл сотрудника выше назначенного для обнаружения или ниже, но текущая итерация >= назначенной
                            if (emp.CurrentAnalystCapacity < emp.AnalystCapacity &&
                                (emp.AnalystSkill >= elem.MinimumSkill || Project.Iteration >= elem.DetectionIterationNumber))
                            {
                                int necessarySkill = (new Random()).Next(100);

                                if (necessarySkill <= emp.AnalystSkill)
                                {
                                    elem.IsFound = true;
                                    elem.FoundByEmployee = emp;
                                    emp.CurrentAnalystCapacity++;

                                    SearchingRequirements(employees, elem.SubRequirements, stakeholder);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        //!UNUSED ANYTHING
        public void GetSubmodules(ref List<Module> modules, Requirement req)
        {
            foreach (Module mod in req.SubModules)
                modules.Add(mod);

            foreach (Requirement r in req.SubRequirements.Where(x => x.IsFound))
                GetSubmodules(ref modules, r);
        }
        public void AddJobInPlan(Module module, Employee developer, Employee tester)
        {
            module.Developer = developer;
            module.Tester = tester;
        }
        //!TEMPORARY
        public void RealizePlan()
        {
            Random rnd = new Random();
            int days = rnd.Next(5, 25);
            MessageBox.Show("Затраченное время на разработку " + days.ToString() + " дней");

            // Задать случайное количество ошибок после выполненной работы (в зависимости от навыка разработчика)
            foreach (Module job in Jobs)
            {
                Random random = new Random();

                switch (random.Next(10))
                {
                    case 0:
                        job.Errors.Add(new Error(Error.ErrorType.Count));
                        break;
                    case 1:
                        job.Errors.Add(new Error(Error.ErrorType.DivisionByZero));
                        break;
                    case 2:
                        job.Errors.Add(new Error(Error.ErrorType.FloatingPointUnderflow));
                        break;
                    case 3:
                        job.Errors.Add(new Error(Error.ErrorType.FloatinPointOverflow));
                        break;
                    case 4:
                        job.Errors.Add(new Error(Error.ErrorType.HeapOverflowError));
                        break;
                    case 5:
                        job.Errors.Add(new Error(Error.ErrorType.InvalidFloatingPointOperation));
                        break;
                    case 6:
                        job.Errors.Add(new Error(Error.ErrorType.InvalidPointerOperation));
                        break;
                    case 7:
                        job.Errors.Add(new Error(Error.ErrorType.OverlayFileReadError));
                        break;
                    case 8:
                        job.Errors.Add(new Error(Error.ErrorType.OverlayManagerNotInstalled));
                        break;
                    case 9:
                        job.Errors.Add(new Error(Error.ErrorType.RangeCheckError));
                        break;
                    case 10:
                        job.Errors.Add(new Error(Error.ErrorType.StackOverflowError));
                        break;
                    default:
                        job.Errors.Add(new Error(Error.ErrorType.None));
                        break;
                }
                //const int minErrorCount = 100;
                //const int maxErrorCount = 300;
                //job.ErrorsCount = random.Next((int)(minErrorCount - minErrorCount * (job.Developer.DeveloperSkill / 100.0)),
                //    (int)(maxErrorCount - maxErrorCount * (job.Developer.DeveloperSkill / 100.0)));
            }
        }

        //!TEMPORARY
        public void Developing()
        {

        }

        //!TEMPORARY
        public void AssignTest(Module module, List<Test> tests)
        {
            module.Tests.AddRange(tests);
            module.Tests.Distinct().ToList();
        }
        //!TEMPORARY
        public void DeassignTest(Module module, Test test)
        {
            module.Tests.Remove(test);
        }
        //!TEMPORARY
        public void ExecuteStabilization()
        {
            Random rnd = new Random();
            int days = rnd.Next(5, 25);
            MessageBox.Show("Затраченное время на разработку " + days.ToString() + " дней");

            // Убрать случайное количество ошибок после стабилизации (в зависимотси от навыка тестера)
            foreach (Module job in Jobs)
            {
                Random random = new Random();
                job.Errors.Clear();

                //const int minErrorCount = 10;
                //const int maxErrorCount = 30;
                //job.ErrorsCount -= random.Next((int)(minErrorCount * (job.Tester.TesterSkill / 100.0)),
                //    (int)(maxErrorCount * (job.Tester.TesterSkill / 100.0)));
            }
        }

        //!TEMPORARY
        public void ShowReport()
        {

        }

        public void NextIteration()
        {
            Project.IncrementIteration();
        }
    }
}
