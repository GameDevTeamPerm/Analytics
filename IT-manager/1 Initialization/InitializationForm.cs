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
        public Project project;

        public InitializationForm(Project project)
        {
            InitializeComponent();
            cmbStakeholders.SelectedIndex = 0;
            this.project = project;


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
                    Employee employee = project.Content.PossibleEmployees.Where(x => x.Name == row.Cells[0].Value.ToString()).First();
                    project.AddEmployee(employee);
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
                Employee employee = project.Content.PossibleEmployees.Where(x => x.Name == row.Cells[0].Value.ToString()).First();
                project.RemoveEmployee(employee);
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
                //Отсортировывает список сотрудников, сначала плохие затем хорошие
                dgvSendingEmployees.Sort(dgvSendingEmployees.Columns[1], 0);

                List<Employee> employees = new List<Employee>();
                foreach (DataGridViewRow row in dgvSendingEmployees.Rows)
                {
                    employees.Add(project.Content.PossibleEmployees.Where(x => x.Name == row.Cells[0].Value.ToString()).First());
                }

                FindingRequirements(employees, project.Content.Requirements, cmbStakeholders.Text);
                foreach (Employee emp in employees)
                {
                    emp.ClearCurrentCapacity();
                }

                project.IncrementDay();

                UpdateTreeViewKnownRequirements();

                labelDay.Text = "День: " + project.PassedDays;
            }
            else
            {
                MessageBox.Show("Некого отправлять к заказчику", "Не выбрано сотрудников", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTreeViewKnownRequirements()
        {
            treeView.Nodes.Clear();

            List<TreeNode> tns = project.KnownRequirements;

            foreach (TreeNode tn in tns)
            {
                treeView.Nodes.Add(tn);
            }

            treeView.ExpandAll();
        }

        private void FindingRequirements(List<Employee> employees, List<Requirement> reqElems, string stakeholder)
        {
            foreach (Requirement elem in reqElems)
            {
                if (elem.IsFound || elem.StakeholderName == stakeholder)
                {
                    if (elem.IsFound)
                    {
                        FindingRequirements(employees, elem.SubRequirements, stakeholder);
                    }
                    else
                    {
                        foreach (Employee emp in employees)
                        {
                            //Если скилл сотрудника выше назначенного для обнаружения или ниже, но текущая итерация >= назначенной
                            if (emp.CurrentAnalystCapacity < emp.AnalystCapacity &&
                                (emp.AnalystSkill >= elem.MinimumSkill || project.Iteration >= elem.DetectionIterationNumber))
                            {
                                int necessarySkill = (new Random()).Next(100);

                                if (necessarySkill <= emp.AnalystSkill)
                                {
                                    elem.IsFound = true;
                                    elem.Employee = emp;
                                    emp.CurrentAnalystCapacity++;

                                    FindingRequirements(employees, elem.SubRequirements, stakeholder);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnLabourExchange_Click(object sender, EventArgs e)
        {
            WorkersForm frmW = new WorkersForm(project.Content.PossibleEmployees);
            Hide();
            frmW.ShowDialog();
            Show();
            UpdateTableOfEmployees();
        }

        private void UpdateTableOfEmployees()
        {
            dgvEmployees.Rows.Clear();
            foreach (Employee emp in project.Content.PossibleEmployees.Where(x => x.isHired).ToList())
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
