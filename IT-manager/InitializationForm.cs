using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_manager
{
    public partial class InitializationForm : Form
    {
        public bool nextStage = false;
        public ItManager itManager;

        public InitializationForm(ItManager _itManager)
        {
            InitializeComponent();
            itManager = _itManager;
            cmbStakeholders.Items.AddRange(itManager.Stakeholders.ToArray());
            cmbStakeholders.SelectedIndex = 0;

            // Чтобы присовить список элементу DataGridView, нужно задать свойства (а не поля) у элементов списка
            UpdateTableOfEmployees();
            UpdateTreeViewKnownRequirements();
        }

        private void btnHireEmployee_Click(object sender, EventArgs e)
        {
            List<string> namesOfSendingEmploees = new List<string>();
            foreach (DataGridViewRow row in dgvSendingEmployees.Rows)
            {
                namesOfSendingEmploees.Add(row.Cells[0].Value.ToString());
            }

            foreach (DataGridViewRow row in dgvEmployees.SelectedRows)
            {
                if (!namesOfSendingEmploees.Contains(row.Cells[0].Value.ToString()))
                {
                    Employee employee = itManager.Employees.Where(x => x.Name == row.Cells[0].Value.ToString()).First();
                    itManager.HireEmployee(employee);
                    dgvSendingEmployees.Rows.Add(employee.Name, employee.AnalystSkill, employee.Salary);
                    namesOfSendingEmploees.Add(row.Cells[0].Value.ToString());
                }
            }
        }

        private void btnFireEmployee_Click(object sender, EventArgs e)
        {
            List<int> deletedIndexRow = new List<int>();
            foreach (DataGridViewRow row in dgvSendingEmployees.SelectedRows)
            {
                Employee employee = itManager.Employees.Where(x => x.Name == row.Cells[0].Value.ToString()).First();
                itManager.FireEmployee(employee);
                deletedIndexRow.Add(row.Index);
            }
            deletedIndexRow.Reverse();
            foreach (int ind in deletedIndexRow)
            {
                dgvSendingEmployees.Rows.RemoveAt(ind);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (dgvSendingEmployees.Rows.Count != 0)
            {
                List<Employee> sendingEmployees = new List<Employee>();
                foreach (DataGridViewRow row in dgvSendingEmployees.Rows)
                {
                    sendingEmployees.Add(itManager.Employees.Where(x => x.Name == row.Cells[0].Value.ToString()).First());
                }

                itManager.SendToStakeholder(sendingEmployees, stakeholder: cmbStakeholders.Text);

                UpdateTreeViewKnownRequirements();
                labelDay.Text = "День: " + itManager.PassedDays;
            }
            else
            {
                MessageBox.Show("Некого отправлять к заказчику", "Не выбрано сотрудников", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTreeViewKnownRequirements()
        {
            treeView.Nodes.Clear();

            List<TreeNode> tns = itManager.GetTreeNodeOfKnownRequirements;

            foreach (TreeNode tn in tns)
            {
                treeView.Nodes.Add(tn);
            }

            treeView.ExpandAll();
        }

        private void btnLabourExchange_Click(object sender, EventArgs e)
        {
            WorkersForm frmW = new WorkersForm(itManager.Employees);
            Hide();
            frmW.ShowDialog();
            Show();
            UpdateTableOfEmployees();
        }

        private void UpdateTableOfEmployees()
        {
            dgvEmployees.Rows.Clear();
            foreach (Employee emp in itManager.HiredEmployees)
            {
                dgvEmployees.Rows.Add(emp.Name,
                    emp.AnalystSkill + " (" + emp.AnalystCapacity + " в день)",
                    emp.DeveloperSkill + " (" + emp.DeveloperCapacity + " в день)",
                    emp.TesterSkill + " (" + emp.TesterCapacity + " в день)",
                    emp.Salary);
            }
        }

        private void treeView_MouseDown(object sender, MouseEventArgs e)
        {
            if (!SelectedNode(treeView.Nodes, new Point(e.X, e.Y)))
            {
                treeView.SelectedNode = null;
            }
        }
        private bool SelectedNode(TreeNodeCollection nodes, Point p)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Bounds.Contains(p) || SelectedNode(node.Nodes, p))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnStartPlaning_Click(object sender, EventArgs e)
        {
            nextStage = true;
            Close();
        }
    }
}
