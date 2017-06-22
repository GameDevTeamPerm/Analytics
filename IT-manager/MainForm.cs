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
    public partial class MainForm : Form
    {
        Project project = new Project(2000, new List<Employee>(), new Content());

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            rtbDescription.Text = project.Content.ProjectDescription;
            rtbTask.Text = project.Content.ProjectTask;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Hide();
            bool closing = false;
            int currentStage = 0;

            do
            {
                if (++currentStage > 4)
                {
                    project.IncrementIteration();
                    currentStage = 1;
                }

                switch (currentStage)
                {
                    case 1:
                        InitializationForm initForm = new InitializationForm(project);
                        initForm.ShowDialog();
                        closing = !initForm.nextStage;
                        break;

                    case 2:
                        PlanningForm planForm = new PlanningForm(project);
                        planForm.ShowDialog();
                        closing = !planForm.nextStage;
                        break;

                    case 3:
                        StabilizationForm stabForm = new StabilizationForm(project);
                        stabForm.ShowDialog();
                        closing = !stabForm.nextStage;
                        break;

                    case 4:
                        DeploymentForm deplForm = new DeploymentForm(project);
                        deplForm.ShowDialog();
                        closing = !deplForm.nextStage;
                        break;

                    default:
                        break;
                }

            } while (!closing);

            Close();
        }
    }
}
