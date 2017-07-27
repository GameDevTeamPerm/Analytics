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
        public ItManager itManager;

        public StabilizationForm(ItManager _itManager)
        {
            InitializeComponent();
            itManager = _itManager;
            dgvListOfJobs.DataSource = itManager.Jobs;
            dgvTests.DataSource = itManager.Tests;
        }

        private void btnJobsSelection_Click(object sender, EventArgs e)
        {
            List<Test> testsToJob = new List<Test>();
            for (int i = 0; i < dgvTests.SelectedRows.Count; i++)
            {
                testsToJob.Add(dgvTests.SelectedRows[i].DataBoundItem as Test);
            }

            Module job = dgvListOfJobs.SelectedRows[0].DataBoundItem as Module;

            itManager.AssignTest(job, testsToJob);

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
            itManager.ExecuteStabilization();

            nextStage = true;
            Close();
        }
    }
}
