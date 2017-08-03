using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_manager
{
    public class Employee
    {
        public string Name { get; set; }
        [Browsable(false)]
        public string Image { get; set; }

        public double AnalystSkill { get; set; }
        public int AnalystCapacity { get; set; }
        public int CurrentAnalystCapacity = 0;

        public int DeveloperSkill { get; set; }
        public int DeveloperCapacity { get; set; }
        public int CurrentDeveloperCapacity = 0;

        public double TesterSkill { get; set; }
        public int TesterCapacity { get; set; }
        public int CurrentTesterCapacity = 0;

        public int Salary { get; set; }
        public bool isHired { get; set; }

        public Employee(string name, string image, int analystSkill, int analystCapacity, int developerSkill, int developerCapacity, int testerSkill, int testerCapacity, int salary)
        {
            Name = name;
            Image = image;

            AnalystSkill = analystSkill;
            AnalystCapacity = analystCapacity;
            DeveloperSkill = developerSkill;
            DeveloperCapacity = developerCapacity;
            TesterSkill = testerSkill;
            TesterCapacity = testerCapacity;

            Salary = salary;
            isHired = false;
        }

        public override string ToString()
        {
            //return string.Format("Сотрудник {0}\nСкилл аналитика {1}\nСкилл разработчика {1}\nСкилл тестировщика {1}\nЗарплата {2}", Name, AnalystSkill, DeveloperSkill, TesterSkill, Salary);
            return string.Format(Name);
        }

        public void ClearCurrentCapacity()
        {
            CurrentAnalystCapacity = 0;
            CurrentDeveloperCapacity = 0;
            CurrentTesterCapacity = 0;
        }

        public void Hiring()
        {
            isHired = true;
        }

        public void Unhiring()
        {
            isHired = false;
        }
    }
}
