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
    public partial class DeploymentForm : Form
    {
        public bool nextStage = false;
        public Project project;

        public DeploymentForm(Project project)
        {
            InitializeComponent();
            this.project = project;
            cbSelectStakeholder.SelectedIndex = 0;
        }

        private void btnNextIteration_Click(object sender, EventArgs e)
        {
            // Сообщение, появляющееся при нажатии на кнопку, в случае отсутствия ошибок и новых требований 
            //MessageBox.Show("Проект соответствует всем требованиям. Проект сдан. Поздравляем!", "Проект принят", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            nextStage = true;
            Close();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            List<Report> reports = new List<Report>();
            /* Добавляем в модули случайные ошибки, пока их количество не станет равно 
            количеству ошибок допущенных после планирования, разработки и стабилизации*/
            foreach (Job job in project.Jobs)
            {
                for (int i = 0; i < job.ErrorsCount; i++)
                {
                    Error error = new Error();
                    error.SetRandomErrorType();
                    job.Module.Errors.Add(error);
                    Report report = new Report(job.Module, error);
                    reports.Add(report);
                }
            }

            dgvReportErrors.DataSource = reports;
        }
    }
}
