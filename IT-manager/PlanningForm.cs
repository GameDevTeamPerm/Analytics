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
        public ItManager itManager;

        public HashSet<Module> modules;

        public PlanningForm(ItManager _itManager)
        {
            InitializeComponent();

            itManager = _itManager;

            dgvDevelopersToJob.DataSource = itManager.HiredEmployees;
            dgvTestersToJob.DataSource = itManager.HiredEmployees;

            modules = new HashSet<Module>();
            foreach (Requirement req in itManager.Requirements)
            {
                modules.UnionWith(req.AllSubModules);
            }
            dgvModulesToJob.DataSource = modules.Where(x => x.Requirement.IsFound).ToList();
        }

        //!UNWRONG OPERATION
        private void btnStartJob_Click(object sender, EventArgs e)
        {
            itManager.RealizePlan();

            nextStage = true;
            Close();
            //throw new NotImplementedException("Переход на следующий этап, передача " + "списка назначенных работ (List<Job>) следующей форме.");
        }

        private void btnAssignJob_Click(object sender, EventArgs e)
        {
            Employee developer = dgvDevelopersToJob.SelectedRows[0].DataBoundItem as Employee;
            Employee tester = dgvTestersToJob.SelectedRows[0].DataBoundItem as Employee;
            Module module = dgvModulesToJob.SelectedRows[0].DataBoundItem as Module;

            itManager.AddJobInPlan(module, developer, tester);

            dgvJobs.DataSource = null;
            dgvJobs.DataSource = itManager.Jobs;
        }
    }
}
