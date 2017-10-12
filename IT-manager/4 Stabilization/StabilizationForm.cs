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
    public partial class StabilizationForm : Form
    {
        public bool nextStage = false;
        public Project project;

        public StabilizationForm(Project project)
        {
            InitializeComponent();
            this.project = project;
            dgvListOfJobs.DataSource = project.Jobs;
            dgvTests.DataSource = project.Tests;
        }

        private void btnJobsSelection_Click(object sender, EventArgs e)
        {

            List<Test> testsToJob = new List<Test>();
            for (int i = 0; i < dgvTests.SelectedRows.Count; i++)
            {
                testsToJob.Add(dgvTests.SelectedRows[i].DataBoundItem as Test);
            }

            Job job = dgvListOfJobs.SelectedRows[0].DataBoundItem as Job;
            job.Tests.AddRange(testsToJob);

            dgvReport.DataSource = null;
            dgvReport.DataSource = testsToJob;

        }

        private void btnStabilization_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lblResultOfReport.Text = "Надйено и исправлено " + rnd.Next(5, 16).ToString() +  " ошибок, затрачено " + rnd.Next(3,8) + " дней";
        }

        private void btnStartDeployment_Click(object sender, EventArgs e)
        {
            // Убрать случайное количество ошибок после стабилизации (в зависимотси от навыка тестера)
            foreach (Job job in project.Jobs)
            {
                Random random = new Random();
                const int minErrorCount = 10;
                const int maxErrorCount = 30;
                job.ErrorsCount -= random.Next((int)(minErrorCount * (job.Tester.TesterSkill / 100.0)),
                    (int)(maxErrorCount * (job.Tester.TesterSkill / 100.0)));
            }

            nextStage = true;
            Close();
        }
    }
}
