using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_manager
{
    public partial class PlanningForm : Form
    {
        public bool nextStage = false;
        public Project project;

        public HashSet<Module> modules;

        public PlanningForm(Project project)
        {
            InitializeComponent();

            this.project = project;

            dgvDevelopersToJob.DataSource = project.Content.PossibleEmployees.Where(x => x.isHired).ToList();
            dgvTestersToJob.DataSource = project.Content.PossibleEmployees.Where(x => x.isHired).ToList();
            #region Созданеи таблицы вручную - не используется
            /*
            dgvDevelopersToJob.Columns.Add("Name", "Name");
            dgvDevelopersToJob.Columns.Add("SkillDev", "SkillDev");
            dgvDevelopersToJob.Columns.Add("Code", "Code");
            dgvDevelopersToJob.Columns.Add("SkillTest", "SkillTest");
            dgvDevelopersToJob.Columns.Add("Tests", "Tests");
            var lst = employees.Select(x => new string[] 
            {
                x.Name,
                x.DeveloperSkill.ToString(),
                x.DeveloperCapacity.ToString(),
                x.TesterCapacity.ToString(),
                x.TesterSkill.ToString()
            }).ToList();
            foreach (var item in lst)
            {
                dgvDevelopersToJob.Rows.Add(item);
            }
            */
            #endregion

            modules = new HashSet<Module>();
            foreach (Requirement req in project.Content.Requirements)
            {
                modules.UnionWith(req.AllSubModules);
            }
            dgvModulesToJob.DataSource = modules.Where(x => x.IsFound).ToList();
        }

        private void GetSubmodules(ref List<Module> modules, Requirement req)
        {
            foreach (Module mod in req.SubModules)
                modules.Add(mod);

            foreach (Requirement r in req.SubRequirements.Where(x => x.IsFound))
                GetSubmodules(ref modules, r);
        }

        private void btnStartJob_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int days = rnd.Next(5, 25);
            MessageBox.Show("Затраченное время на разработку " + days.ToString() + " дней");

            // Задать случайное количество ошибок после выполненной работы (в зависимости от навыка разработчика)
            foreach (Job job in project.Jobs)
            {
                Random random = new Random();
                const int minErrorCount = 100;
                const int maxErrorCount = 300;
                job.ErrorsCount = random.Next((int)(minErrorCount - minErrorCount * (job.Developer.DeveloperSkill / 100.0)),
                    (int)(maxErrorCount - maxErrorCount * (job.Developer.DeveloperSkill / 100.0)));
            }

            nextStage = true;
            Close();
            //throw new NotImplementedException("Переход на следующий этап, передача " + "списка назначенных работ (List<Job>) следующей форме.");
        }

        private void btnAssignJob_Click(object sender, EventArgs e)
        {
            Employee developer = dgvDevelopersToJob.SelectedRows[0].DataBoundItem as Employee;
            Employee tester = dgvTestersToJob.SelectedRows[0].DataBoundItem as Employee;
            Module module = dgvModulesToJob.SelectedRows[0].DataBoundItem as Module;

            Job job = new Job(module, developer, tester);
            project.Jobs.Add(job);

            dgvJobs.DataSource = null;
            dgvJobs.DataSource = project.Jobs;
        }
    }
}
