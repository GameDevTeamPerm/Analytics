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
        ItManager itManager = new ItManager();
        Content content;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            content = new Content();
            rtbDescription.Text = content.ProjectDescription;
            rtbTask.Text = content.ProjectTask;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Hide();
            bool closing = false;
            int currentStage = 0;

            itManager.StartGame(content);

            do
            {
                if (++currentStage > 4)
                {
                    itManager.NextIteration();
                    currentStage = 1;
                }

                switch (currentStage)
                {
                    case 1:
                        InitializationForm initForm = new InitializationForm(itManager);
                        initForm.ShowDialog();
                        closing = !initForm.nextStage;
                        break;

                    case 2:
                        PlanningForm planForm = new PlanningForm(itManager);
                        planForm.ShowDialog();
                        closing = !planForm.nextStage;
                        break;

                    case 3:
                        StabilizationForm stabForm = new StabilizationForm(itManager);
                        stabForm.ShowDialog();
                        closing = !stabForm.nextStage;
                        break;

                    case 4:
                        DeploymentForm deplForm = new DeploymentForm(itManager);
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
