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
    public partial class WorkersForm : Form
    {
        List<Employee> hiredEmployees;

        int startIndex = 0;
        Employee[] visibleEmployees = new Employee[3];
        public WorkersForm(List<Employee> employees)
        {
            InitializeComponent();
            hiredEmployees = employees;

            for (int i = 0; i < 3; i++)
            {
                visibleEmployees[i] = hiredEmployees[i];
            }

            ShowInfo();
        }

        private void ShowInfo()
        {
            image1.Load(visibleEmployees[0].Image);
            labelName1.Text = visibleEmployees[0].Name;
            labelAnalyst1.Text = visibleEmployees[0].AnalystSkill.ToString() + "%";
            labelAnalystCapacity1.Text = visibleEmployees[0].AnalystCapacity.ToString() + " требований в день";
            labelDeveloper1.Text = visibleEmployees[0].DeveloperSkill.ToString() + "%";
            labelDeveloperCapacity1.Text = visibleEmployees[0].DeveloperCapacity.ToString() + " строк в день";
            labelTester1.Text = visibleEmployees[0].TesterSkill.ToString() + "%";
            labelTesterCapacity1.Text = visibleEmployees[0].TesterCapacity.ToString() + " тестов в день";
            labelSalary1.Text = visibleEmployees[0].Salary.ToString();
            if (visibleEmployees[0].isHired)
            {
                HiredButton(btnHire1);
            }
            else
            {
                UnhiredButton(btnHire1);
            }

            image2.Load(visibleEmployees[1].Image);
            labelName2.Text = visibleEmployees[1].Name;
            labelAnalyst2.Text = visibleEmployees[1].AnalystSkill.ToString() + "%";
            labelAnalystCapacity2.Text = visibleEmployees[1].AnalystCapacity.ToString() + " требований в день";
            labelDeveloper2.Text = visibleEmployees[1].DeveloperSkill.ToString() + "%";
            labelDeveloperCapacity2.Text = visibleEmployees[1].DeveloperCapacity.ToString() + " строк в день";
            labelTester2.Text = visibleEmployees[1].TesterSkill.ToString() + "%";
            labelTesterCapacity2.Text = visibleEmployees[1].TesterCapacity.ToString() + " тестов в день";
            labelSalary2.Text = visibleEmployees[1].Salary.ToString();
            if (visibleEmployees[1].isHired)
            {
                HiredButton(btnHire2);
            }
            else
            {
                UnhiredButton(btnHire2);
            }

            image3.Load(visibleEmployees[2].Image);
            labelName3.Text = visibleEmployees[2].Name;
            labelAnalyst3.Text = visibleEmployees[2].AnalystSkill.ToString() + "%";
            labelAnalystCapacity3.Text = visibleEmployees[2].AnalystCapacity.ToString() + " требований в день";
            labelDeveloper3.Text = visibleEmployees[2].DeveloperSkill.ToString() + "%";
            labelDeveloperCapacity3.Text = visibleEmployees[2].DeveloperCapacity.ToString() + " строк в день";
            labelTester3.Text = visibleEmployees[2].TesterSkill.ToString() + "%";
            labelTesterCapacity3.Text = visibleEmployees[2].TesterCapacity.ToString() + " тестов в день";
            labelSalary3.Text = visibleEmployees[2].Salary.ToString();
            if (visibleEmployees[2].isHired)
            {
                HiredButton(btnHire3);
            }
            else
            {
                UnhiredButton(btnHire3);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (++startIndex > hiredEmployees.Count - 1)
            {
                startIndex = 0;
            }

            visibleEmployees[0] = hiredEmployees[startIndex];
            if (startIndex + 1 > hiredEmployees.Count - 1)
            {
                visibleEmployees[1] = hiredEmployees[0];
                visibleEmployees[2] = hiredEmployees[1];
            }
            else
            {
                visibleEmployees[1] = hiredEmployees[startIndex + 1];
                visibleEmployees[2] = startIndex + 2 > hiredEmployees.Count - 1
                    ? hiredEmployees[0]
                    : hiredEmployees[startIndex + 2];
            }

            ShowInfo();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (--startIndex < 0)
            {
                startIndex = hiredEmployees.Count - 1;
            }

            visibleEmployees[0] = hiredEmployees[startIndex];
            if (startIndex + 1 > hiredEmployees.Count - 1)
            {
                visibleEmployees[1] = hiredEmployees[0];
                visibleEmployees[2] = hiredEmployees[1];
            }
            else
            {
                visibleEmployees[1] = hiredEmployees[startIndex + 1];
                visibleEmployees[2] = startIndex + 2 > hiredEmployees.Count - 1
                    ? hiredEmployees[0]
                    : hiredEmployees[startIndex + 2];
            }

            ShowInfo();
        }

        private void btnHire1_Click(object sender, EventArgs e)
        {
            visibleEmployees[0].isHired = !visibleEmployees[0].isHired;
            if (visibleEmployees[0].isHired)
            {
                HiredButton(btnHire1);
            }
            else
            {
                UnhiredButton(btnHire1);
            }
        }

        private void btnHire2_Click(object sender, EventArgs e)
        {
            visibleEmployees[1].isHired = !visibleEmployees[1].isHired;
            if (visibleEmployees[1].isHired)
            {
                HiredButton(btnHire2);
            }
            else
            {
                UnhiredButton(btnHire2);
            }
        }

        private void btnHire3_Click(object sender, EventArgs e)
        {
            visibleEmployees[2].isHired = !visibleEmployees[2].isHired;
            if (visibleEmployees[2].isHired)
            {
                HiredButton(btnHire3);
            }
            else
            {
                UnhiredButton(btnHire3);
            }
        }

        private void HiredButton(Button btn)
        {
            btn.Text = "Уволить";
            btn.BackColor = Color.Firebrick;
            btn.ForeColor = Color.White;
        }
        private void UnhiredButton(Button btn)
        {
            btn.Text = "Нанять";
            btn.BackColor = Color.ForestGreen;
            btn.ForeColor = Color.White;
        }
    }
}
