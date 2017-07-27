namespace IT_manager
{
    partial class InitializationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPossibleEmployees = new System.Windows.Forms.Label();
            this.lblProjectEmployees = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.NameEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Analyst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Developer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSendingEmployees = new System.Windows.Forms.DataGridView();
            this.NameEmp2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Analyst2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSendEmployee = new System.Windows.Forms.Button();
            this.btnReturnEmployee = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbAnalysisPhase = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStakeholders = new System.Windows.Forms.ComboBox();
            this.btnLabourExchange = new System.Windows.Forms.Button();
            this.labelDay = new System.Windows.Forms.Label();
            this.gpDeploymentPhase = new System.Windows.Forms.GroupBox();
            this.btnStartPlaning = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendingEmployees)).BeginInit();
            this.gbAnalysisPhase.SuspendLayout();
            this.gpDeploymentPhase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPossibleEmployees
            // 
            this.lblPossibleEmployees.AutoSize = true;
            this.lblPossibleEmployees.Location = new System.Drawing.Point(144, 31);
            this.lblPossibleEmployees.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPossibleEmployees.Name = "lblPossibleEmployees";
            this.lblPossibleEmployees.Size = new System.Drawing.Size(252, 25);
            this.lblPossibleEmployees.TabIndex = 0;
            this.lblPossibleEmployees.Text = "Сотрудники в компании";
            // 
            // lblProjectEmployees
            // 
            this.lblProjectEmployees.AutoSize = true;
            this.lblProjectEmployees.Location = new System.Drawing.Point(720, 31);
            this.lblProjectEmployees.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProjectEmployees.Name = "lblProjectEmployees";
            this.lblProjectEmployees.Size = new System.Drawing.Size(388, 25);
            this.lblProjectEmployees.TabIndex = 1;
            this.lblProjectEmployees.Text = "Отправляемые на работу сотрудники";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameEmp,
            this.Analyst,
            this.Developer,
            this.Tester,
            this.Salary});
            this.dgvEmployees.Location = new System.Drawing.Point(12, 62);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(6);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(680, 288);
            this.dgvEmployees.TabIndex = 2;
            // 
            // NameEmp
            // 
            this.NameEmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameEmp.HeaderText = "Имя";
            this.NameEmp.Name = "NameEmp";
            this.NameEmp.ReadOnly = true;
            this.NameEmp.Width = 60;
            // 
            // Analyst
            // 
            this.Analyst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Analyst.HeaderText = "Аналитик";
            this.Analyst.Name = "Analyst";
            this.Analyst.ReadOnly = true;
            this.Analyst.Width = 80;
            // 
            // Developer
            // 
            this.Developer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Developer.HeaderText = "Разработчик";
            this.Developer.Name = "Developer";
            this.Developer.ReadOnly = true;
            this.Developer.Width = 85;
            // 
            // Tester
            // 
            this.Tester.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Tester.HeaderText = "Тестировщик";
            this.Tester.Name = "Tester";
            this.Tester.ReadOnly = true;
            this.Tester.Width = 85;
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Salary.HeaderText = "Зарплата";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Width = 60;
            // 
            // dgvSendingEmployees
            // 
            this.dgvSendingEmployees.AllowUserToAddRows = false;
            this.dgvSendingEmployees.AllowUserToDeleteRows = false;
            this.dgvSendingEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSendingEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameEmp2,
            this.Analyst2,
            this.Salary2});
            this.dgvSendingEmployees.Location = new System.Drawing.Point(760, 62);
            this.dgvSendingEmployees.Margin = new System.Windows.Forms.Padding(6);
            this.dgvSendingEmployees.Name = "dgvSendingEmployees";
            this.dgvSendingEmployees.ReadOnly = true;
            this.dgvSendingEmployees.RowHeadersVisible = false;
            this.dgvSendingEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSendingEmployees.Size = new System.Drawing.Size(350, 288);
            this.dgvSendingEmployees.TabIndex = 2;
            // 
            // NameEmp2
            // 
            this.NameEmp2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameEmp2.HeaderText = "Имя";
            this.NameEmp2.Name = "NameEmp2";
            this.NameEmp2.ReadOnly = true;
            this.NameEmp2.Width = 50;
            // 
            // Analyst2
            // 
            this.Analyst2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Analyst2.HeaderText = "Аналитик";
            this.Analyst2.Name = "Analyst2";
            this.Analyst2.ReadOnly = true;
            // 
            // Salary2
            // 
            this.Salary2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salary2.HeaderText = "Зарплата";
            this.Salary2.Name = "Salary2";
            this.Salary2.ReadOnly = true;
            // 
            // btnSendEmployee
            // 
            this.btnSendEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendEmployee.Location = new System.Drawing.Point(704, 133);
            this.btnSendEmployee.Margin = new System.Windows.Forms.Padding(6);
            this.btnSendEmployee.Name = "btnSendEmployee";
            this.btnSendEmployee.Size = new System.Drawing.Size(44, 69);
            this.btnSendEmployee.TabIndex = 3;
            this.btnSendEmployee.Text = ">";
            this.btnSendEmployee.UseVisualStyleBackColor = true;
            this.btnSendEmployee.Click += new System.EventHandler(this.btnHireEmployee_Click);
            // 
            // btnReturnEmployee
            // 
            this.btnReturnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturnEmployee.Location = new System.Drawing.Point(704, 227);
            this.btnReturnEmployee.Margin = new System.Windows.Forms.Padding(6);
            this.btnReturnEmployee.Name = "btnReturnEmployee";
            this.btnReturnEmployee.Size = new System.Drawing.Size(44, 69);
            this.btnReturnEmployee.TabIndex = 3;
            this.btnReturnEmployee.Text = "<";
            this.btnReturnEmployee.UseVisualStyleBackColor = true;
            this.btnReturnEmployee.Click += new System.EventHandler(this.btnFireEmployee_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(964, 362);
            this.btnSend.Margin = new System.Windows.Forms.Padding(6);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(146, 44);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Отправить";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // gbAnalysisPhase
            // 
            this.gbAnalysisPhase.Controls.Add(this.label2);
            this.gbAnalysisPhase.Controls.Add(this.cmbStakeholders);
            this.gbAnalysisPhase.Controls.Add(this.btnLabourExchange);
            this.gbAnalysisPhase.Controls.Add(this.dgvSendingEmployees);
            this.gbAnalysisPhase.Controls.Add(this.labelDay);
            this.gbAnalysisPhase.Controls.Add(this.dgvEmployees);
            this.gbAnalysisPhase.Controls.Add(this.btnSend);
            this.gbAnalysisPhase.Controls.Add(this.lblPossibleEmployees);
            this.gbAnalysisPhase.Controls.Add(this.lblProjectEmployees);
            this.gbAnalysisPhase.Controls.Add(this.btnReturnEmployee);
            this.gbAnalysisPhase.Controls.Add(this.btnSendEmployee);
            this.gbAnalysisPhase.Location = new System.Drawing.Point(24, 23);
            this.gbAnalysisPhase.Margin = new System.Windows.Forms.Padding(6);
            this.gbAnalysisPhase.Name = "gbAnalysisPhase";
            this.gbAnalysisPhase.Padding = new System.Windows.Forms.Padding(6);
            this.gbAnalysisPhase.Size = new System.Drawing.Size(1120, 427);
            this.gbAnalysisPhase.TabIndex = 5;
            this.gbAnalysisPhase.TabStop = false;
            this.gbAnalysisPhase.Text = "Этап анализа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 371);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Выберите стейкхолдера:";
            // 
            // cmbStakeholders
            // 
            this.cmbStakeholders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStakeholders.FormattingEnabled = true;
            this.cmbStakeholders.Location = new System.Drawing.Point(760, 363);
            this.cmbStakeholders.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStakeholders.Name = "cmbStakeholders";
            this.cmbStakeholders.Size = new System.Drawing.Size(196, 33);
            this.cmbStakeholders.TabIndex = 7;
            // 
            // btnLabourExchange
            // 
            this.btnLabourExchange.Location = new System.Drawing.Point(148, 362);
            this.btnLabourExchange.Margin = new System.Windows.Forms.Padding(4);
            this.btnLabourExchange.Name = "btnLabourExchange";
            this.btnLabourExchange.Size = new System.Drawing.Size(268, 44);
            this.btnLabourExchange.TabIndex = 6;
            this.btnLabourExchange.Text = "Биржа труда";
            this.btnLabourExchange.UseVisualStyleBackColor = true;
            this.btnLabourExchange.Click += new System.EventHandler(this.btnLabourExchange_Click);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(552, 31);
            this.labelDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(87, 25);
            this.labelDay.TabIndex = 5;
            this.labelDay.Text = "День: 0";
            // 
            // gpDeploymentPhase
            // 
            this.gpDeploymentPhase.Controls.Add(this.btnStartPlaning);
            this.gpDeploymentPhase.Controls.Add(this.treeView);
            this.gpDeploymentPhase.Controls.Add(this.label1);
            this.gpDeploymentPhase.Location = new System.Drawing.Point(24, 462);
            this.gpDeploymentPhase.Margin = new System.Windows.Forms.Padding(6);
            this.gpDeploymentPhase.Name = "gpDeploymentPhase";
            this.gpDeploymentPhase.Padding = new System.Windows.Forms.Padding(6);
            this.gpDeploymentPhase.Size = new System.Drawing.Size(1120, 404);
            this.gpDeploymentPhase.TabIndex = 6;
            this.gpDeploymentPhase.TabStop = false;
            this.gpDeploymentPhase.Text = "Этап развертывания";
            // 
            // btnStartPlaning
            // 
            this.btnStartPlaning.Location = new System.Drawing.Point(0, 37);
            this.btnStartPlaning.Margin = new System.Windows.Forms.Padding(6);
            this.btnStartPlaning.Name = "btnStartPlaning";
            this.btnStartPlaning.Size = new System.Drawing.Size(372, 44);
            this.btnStartPlaning.TabIndex = 4;
            this.btnStartPlaning.Text = "Перейти на этап планирования";
            this.btnStartPlaning.UseVisualStyleBackColor = true;
            this.btnStartPlaning.Click += new System.EventHandler(this.btnStartPlaning_Click);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(382, 58);
            this.treeView.Margin = new System.Windows.Forms.Padding(4);
            this.treeView.Name = "treeView";
            this.treeView.ShowPlusMinus = false;
            this.treeView.Size = new System.Drawing.Size(718, 333);
            this.treeView.TabIndex = 3;
            this.treeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выявленные требования";
            // 
            // InitializationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 825);
            this.Controls.Add(this.gpDeploymentPhase);
            this.Controls.Add(this.gbAnalysisPhase);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1164, 896);
            this.MinimumSize = new System.Drawing.Size(1164, 896);
            this.Name = "InitializationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendingEmployees)).EndInit();
            this.gbAnalysisPhase.ResumeLayout(false);
            this.gbAnalysisPhase.PerformLayout();
            this.gpDeploymentPhase.ResumeLayout(false);
            this.gpDeploymentPhase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPossibleEmployees;
        private System.Windows.Forms.Label lblProjectEmployees;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridView dgvSendingEmployees;
        private System.Windows.Forms.Button btnSendEmployee;
        private System.Windows.Forms.Button btnReturnEmployee;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox gbAnalysisPhase;
        private System.Windows.Forms.GroupBox gpDeploymentPhase;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Button btnLabourExchange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEmp2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Analyst2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Analyst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Developer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ComboBox cmbStakeholders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartPlaning;
    }
}

