using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_manager
{
    public class Job
    {
        public Job()
        {
            Developer = null;
            Tester = null;
            Module = null;
            Tests = new List<Test>();
        }

        public Job(Module module, Employee developer, Employee tester)
        {
            Developer = developer;
            Tester = tester;
            Module = module;
            Tests = new List<Test>();
        }

        public Employee Analyst
        {
            get
            {
                return (Module.Employee != null)
                    ? Module.Employee
                    : new Employee("Null", "Null", 0, 0, 0, 0, 0, 0, 0);
            }
        }

        public Employee Developer { get; set; }
        public Employee Tester { get; set; }
        public Module Module { get; set; }
        public List<Test> Tests{ get; set; }

        public int ErrorsCount { get; set; }
    }
}
