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
        public ItManager itManager;

        public DeploymentForm(ItManager _itManager)
        {
            InitializeComponent();
            itManager = _itManager;
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
            itManager.ShowReport();
        }
    }
}
