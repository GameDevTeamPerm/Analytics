using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_manager
{
    public class Content
    {
        public string ProjectDescription { get; set; }
        public string ProjectTask { get; set; }
        public List<Stakeholder> Stakeholders { get; set; }
        public List<Requirement> Requirements { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Test> Tests { get; set; }

        public Content()
        {
            Stakeholders = new List<Stakeholder>();
            Requirements = new List<Requirement>();
            Employees = new List<Employee>();
            Tests = new List<Test>();

            LoadProjectDescription();
            LoadProjectTask();
            LoadRequirements();
            LoadEmployees();
            LoadTests();
        }

        private void LoadProjectDescription()
        {
            ProjectDescription = "Директор школы хочет повысить успеваемость школьников по математике. По словам учителя математики, основная проблема – это объем примеров, которые решают школьники. Задачники предлагают малое количество примеров по решению квадратного уравнения. Составлять вручную примеры слишком трудозатратное занятие.";
        }

        private void LoadProjectTask()
        {
            ProjectTask = "Необходимо создать программу, генерирующую примеры для решения квадратного уравнения.";
        }

        private void LoadRequirements()
        {
            Stakeholder client = new Stakeholder("Заказчик", "Client");
            Stakeholders.Add(client);
            
            Stakeholder users = new Stakeholder("Пользователи", "Users");
            Stakeholders.Add(users);

            // Создание первого графа требований и модулей
            Requirement req1 = new Requirement("Вычисление квадратного уравнения", client, 60, 1);

            Requirement req11 = req1.AddSubRequirement("Ввод a, b, c", client, 60, 1);
            req11.AddSubModule("Input(a,b,c)", 100);

            Requirement req111 = req11.AddSubRequirement("Ввод целых числе a, b, c", users, 60, 2);
            req111.AddSubModule("Input(int a, int b, int c)", 100);

            Requirement req1111 = req111.AddSubRequirement("Ввод вещественных чисел a, b, c", users, 60, 3);
            req1111.AddSubModule("Input(double a, double b, double c)", 100);

            Requirement req12 = req1.AddSubRequirement("Решение квадратного уравнения", client, 60, 1);
            req12.AddSubModule("SolveEquation()", 100);
            req12.AddSubModule("Sum()", 50);
            req12.AddSubModule("Deduct()", 50);
            req12.AddSubModule("Mod()", 100);
            req12.AddSubModule("Div()", 100);
            req12.AddSubModule("Multiply()", 200);
            req12.AddSubModule("Sqrt()", 200);
            req12.AddSubModule("Pow()", 300, false);
            req12.AddSubModule("SolveInequality()", 100);

            Requirement req13 = req1.AddSubRequirement("Решение квадратного неравенство", client, 60, 2);
            req13.AddSubModule("Sum()", 50);
            req13.AddSubModule("Deduct()", 50);
            req13.AddSubModule("Mod()", 100);
            req13.AddSubModule("Div()", 100);
            req13.AddSubModule("Multiply()", 200);
            req13.AddSubModule("Sqrt()", 200);
            req13.AddSubModule("Pow()", 300, false);

            // Создание второго графа требований и модулей
            Requirement req2 = new Requirement("Проверка решения пользователя", client, 60, 1);

            Requirement req21 = req2.AddSubRequirement("Таймер (время на решение)", client, 60, 1);
            req21.AddSubModule("Timer()", 100);
            req21.AddSubRequirement("10 мин", users, 60, 2).AddSubModule("TimerRun(int 10)", 100);
            req21.AddSubRequirement("20 мин", users, 60, 2).AddSubModule("TimerRun(int 20)", 100);
            req21.AddSubRequirement("Отключение таймера", users, 60, 2, false).AddSubModule("TimerOff()", 100);

            Requirement req22 = req2.AddSubRequirement("Отображения ответа", client, 60, 1);
            req22.AddSubModule("Answer()", 100);
            req22.AddSubRequirement("С помощью графика", users, 60, 3).AddSubModule("ShowChart()", 100);
            req22.AddSubRequirement("С помощью формулы", users, 60, 3).AddSubModule("ShowFormula()", 100);
            req22.AddSubRequirement("Голосовое сообщение", users, 60, 3, false).AddSubModule("VoiceAnswer()", 100);

            req2.AddSubRequirement("Отображения решения", client, 60, 2).AddSubModule("Decision()", 100);

            // Создание третьего графа требований и модулей
            Requirement req3 = new Requirement("Статистика пользователей ", client, 60, 1);

            Requirement req31 = req3.AddSubRequirement("Кол-во решенных примеров", client, 60, 1);
            req31.AddSubModule("SuccessResult()", 100);
            req31.AddSubRequirement("Процент решенных примеров", users, 60, 2).AddSubModule("ProcentSuccessResult()", 100);
            req3.AddSubRequirement("Среднее время решения", client, 60, 2).AddSubModule("AverageSolving()", 100);

            // Добавление всех описанных требований в список требований
            Requirements.Add(req1);
            Requirements.Add(req2);
            Requirements.Add(req3);
        }

        private void LoadEmployees()
        {
            Employees.Add(new Employee("Алексей", @".\Images\Алексей.jpg", 70, 5, 75, 100, 35, 200, 10500));
            Employees.Add(new Employee("Андрей", @".\Images\Андрей.jpg", 25, 4, 60, 200, 90, 100, 11000));
            Employees.Add(new Employee("Александр", @".\Images\Александр.jpg", 35, 1, 85, 200, 75, 150, 14000));
            Employees.Add(new Employee("Татьяна", @".\Images\Татьяна.jpg", 95, 5, 25, 100, 70, 150, 12500));
            Employees.Add(new Employee("Мария", @".\Images\Мария.jpg", 60, 2, 35, 100, 55, 200, 10000));
        }

        private void LoadTests()
        {
            Tests.Add(new Test("Проверка входных данных"));
            Tests.Add(new Test("Проверка выходных данных"));
            Tests.Add(new Test("Классы входных данных"));
            Tests.Add(new Test("Классы выходных данных"));
            Tests.Add(new Test("Тестирование времени работы", false));
        }
    }
}
