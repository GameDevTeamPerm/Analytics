namespace IT_manager
{
    partial class PlanningForm
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
            this.lblDevelopersToJob = new System.Windows.Forms.Label();
            this.lblModulesToJob = new System.Windows.Forms.Label();
            this.gbJobAssignment = new System.Windows.Forms.GroupBox();
            this.dgvTestersToJob = new System.Windows.Forms.DataGridView();
            this.lblTestersToJob = new System.Windows.Forms.Label();
            this.btnAssignJob = new System.Windows.Forms.Button();
            this.lblJobAssignmentTip = new System.Windows.Forms.Label();
            this.dgvModulesToJob = new System.Windows.Forms.DataGridView();
            this.dgvDevelopersToJob = new System.Windows.Forms.DataGridView();
            this.gbJobs = new System.Windows.Forms.GroupBox();
            this.lblStartJobTip = new System.Windows.Forms.Label();
            this.btnStartJob = new System.Windows.Forms.Button();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.lblJobs = new System.Windows.Forms.Label();
            this.gbJobAssignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestersToJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulesToJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevelopersToJob)).BeginInit();
            this.gbJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDevelopersToJob
            // 
            this.lblDevelopersToJob.AutoSize = true;
            this.lblDevelopersToJob.Location = new System.Drawing.Point(12, 413);
            this.lblDevelopersToJob.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDevelopersToJob.Name = "lblDevelopersToJob";
            this.lblDevelopersToJob.Size = new System.Drawing.Size(146, 25);
            this.lblDevelopersToJob.TabIndex = 4;
            this.lblDevelopersToJob.Text = "Програмисты";
            // 
            // lblModulesToJob
            // 
            this.lblModulesToJob.AutoSize = true;
            this.lblModulesToJob.Location = new System.Drawing.Point(12, 31);
            this.lblModulesToJob.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblModulesToJob.Name = "lblModulesToJob";
            this.lblModulesToJob.Size = new System.Drawing.Size(89, 25);
            this.lblModulesToJob.TabIndex = 5;
            this.lblModulesToJob.Text = "Модули";
            // 
            // gbJobAssignment
            // 
            this.gbJobAssignment.Controls.Add(this.dgvTestersToJob);
            this.gbJobAssignment.Controls.Add(this.lblTestersToJob);
            this.gbJobAssignment.Controls.Add(this.btnAssignJob);
            this.gbJobAssignment.Controls.Add(this.lblJobAssignmentTip);
            this.gbJobAssignment.Controls.Add(this.dgvModulesToJob);
            this.gbJobAssignment.Controls.Add(this.dgvDevelopersToJob);
            this.gbJobAssignment.Controls.Add(this.lblDevelopersToJob);
            this.gbJobAssignment.Controls.Add(this.lblModulesToJob);
            this.gbJobAssignment.Location = new System.Drawing.Point(24, 23);
            this.gbJobAssignment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbJobAssignment.Name = "gbJobAssignment";
            this.gbJobAssignment.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbJobAssignment.Size = new System.Drawing.Size(942, 1229);
            this.gbJobAssignment.TabIndex = 7;
            this.gbJobAssignment.TabStop = false;
            this.gbJobAssignment.Text = "Назначение работы";
            // 
            // dgvTestersToJob
            // 
            this.dgvTestersToJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestersToJob.Location = new System.Drawing.Point(12, 769);
            this.dgvTestersToJob.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvTestersToJob.Name = "dgvTestersToJob";
            this.dgvTestersToJob.ReadOnly = true;
            this.dgvTestersToJob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestersToJob.Size = new System.Drawing.Size(918, 288);
            this.dgvTestersToJob.TabIndex = 11;
            // 
            // lblTestersToJob
            // 
            this.lblTestersToJob.AutoSize = true;
            this.lblTestersToJob.Location = new System.Drawing.Point(12, 738);
            this.lblTestersToJob.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTestersToJob.Name = "lblTestersToJob";
            this.lblTestersToJob.Size = new System.Drawing.Size(97, 25);
            this.lblTestersToJob.TabIndex = 10;
            this.lblTestersToJob.Text = "Тестеры";
            // 
            // btnAssignJob
            // 
            this.btnAssignJob.Location = new System.Drawing.Point(782, 1173);
            this.btnAssignJob.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAssignJob.Name = "btnAssignJob";
            this.btnAssignJob.Size = new System.Drawing.Size(160, 44);
            this.btnAssignJob.TabIndex = 8;
            this.btnAssignJob.Text = "Назначить работу";
            this.btnAssignJob.UseVisualStyleBackColor = true;
            this.btnAssignJob.Click += new System.EventHandler(this.btnAssignJob_Click);
            // 
            // lblJobAssignmentTip
            // 
            this.lblJobAssignmentTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJobAssignmentTip.AutoSize = true;
            this.lblJobAssignmentTip.Location = new System.Drawing.Point(390, 1067);
            this.lblJobAssignmentTip.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblJobAssignmentTip.MaximumSize = new System.Drawing.Size(540, 0);
            this.lblJobAssignmentTip.Name = "lblJobAssignmentTip";
            this.lblJobAssignmentTip.Size = new System.Drawing.Size(524, 100);
            this.lblJobAssignmentTip.TabIndex = 9;
            this.lblJobAssignmentTip.Text = "Чтобы назначить сотруднику работу, выберите сотрудника (из первого списка) и моду" +
    "ль (из второго списка), который он должен выполнить. Назначенные работы появляют" +
    "ся в списке справа.";
            // 
            // dgvModulesToJob
            // 
            this.dgvModulesToJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModulesToJob.Location = new System.Drawing.Point(12, 62);
            this.dgvModulesToJob.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvModulesToJob.Name = "dgvModulesToJob";
            this.dgvModulesToJob.ReadOnly = true;
            this.dgvModulesToJob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModulesToJob.Size = new System.Drawing.Size(918, 346);
            this.dgvModulesToJob.TabIndex = 8;
            // 
            // dgvDevelopersToJob
            // 
            this.dgvDevelopersToJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevelopersToJob.Location = new System.Drawing.Point(12, 444);
            this.dgvDevelopersToJob.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvDevelopersToJob.Name = "dgvDevelopersToJob";
            this.dgvDevelopersToJob.ReadOnly = true;
            this.dgvDevelopersToJob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevelopersToJob.Size = new System.Drawing.Size(918, 288);
            this.dgvDevelopersToJob.TabIndex = 8;
            // 
            // gbJobs
            // 
            this.gbJobs.Controls.Add(this.lblStartJobTip);
            this.gbJobs.Controls.Add(this.btnStartJob);
            this.gbJobs.Controls.Add(this.dgvJobs);
            this.gbJobs.Controls.Add(this.lblJobs);
            this.gbJobs.Location = new System.Drawing.Point(978, 23);
            this.gbJobs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbJobs.Name = "gbJobs";
            this.gbJobs.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbJobs.Size = new System.Drawing.Size(856, 1229);
            this.gbJobs.TabIndex = 8;
            this.gbJobs.TabStop = false;
            this.gbJobs.Text = "Назначенная работа";
            // 
            // lblStartJobTip
            // 
            this.lblStartJobTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartJobTip.AutoSize = true;
            this.lblStartJobTip.Location = new System.Drawing.Point(304, 1092);
            this.lblStartJobTip.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStartJobTip.MaximumSize = new System.Drawing.Size(540, 0);
            this.lblStartJobTip.Name = "lblStartJobTip";
            this.lblStartJobTip.Size = new System.Drawing.Size(538, 75);
            this.lblStartJobTip.TabIndex = 11;
            this.lblStartJobTip.Text = "Указанные здесь работники начинают работать над назначенным им модулями, игра пер" +
    "еходит на этап реализации.";
            // 
            // btnStartJob
            // 
            this.btnStartJob.Location = new System.Drawing.Point(310, 1173);
            this.btnStartJob.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnStartJob.Name = "btnStartJob";
            this.btnStartJob.Size = new System.Drawing.Size(534, 44);
            this.btnStartJob.TabIndex = 10;
            this.btnStartJob.Text = "Начать работу (выполнить этап разработки)";
            this.btnStartJob.UseVisualStyleBackColor = true;
            this.btnStartJob.Click += new System.EventHandler(this.btnStartJob_Click);
            // 
            // dgvJobs
            // 
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Location = new System.Drawing.Point(12, 62);
            this.dgvJobs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.ReadOnly = true;
            this.dgvJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobs.Size = new System.Drawing.Size(844, 996);
            this.dgvJobs.TabIndex = 10;
            // 
            // lblJobs
            // 
            this.lblJobs.AutoSize = true;
            this.lblJobs.Location = new System.Drawing.Point(12, 31);
            this.lblJobs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblJobs.Name = "lblJobs";
            this.lblJobs.Size = new System.Drawing.Size(84, 25);
            this.lblJobs.TabIndex = 10;
            this.lblJobs.Text = "Работа";
            // 
            // PlanningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1858, 1275);
            this.Controls.Add(this.gbJobs);
            this.Controls.Add(this.gbJobAssignment);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PlanningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Планирование";
            this.gbJobAssignment.ResumeLayout(false);
            this.gbJobAssignment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestersToJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulesToJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevelopersToJob)).EndInit();
            this.gbJobs.ResumeLayout(false);
            this.gbJobs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDevelopersToJob;
        private System.Windows.Forms.Label lblModulesToJob;
        private System.Windows.Forms.GroupBox gbJobAssignment;
        private System.Windows.Forms.Button btnAssignJob;
        private System.Windows.Forms.Label lblJobAssignmentTip;
        private System.Windows.Forms.DataGridView dgvModulesToJob;
        private System.Windows.Forms.DataGridView dgvDevelopersToJob;
        private System.Windows.Forms.GroupBox gbJobs;
        private System.Windows.Forms.Button btnStartJob;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.Label lblJobs;
        private System.Windows.Forms.Label lblStartJobTip;
        private System.Windows.Forms.DataGridView dgvTestersToJob;
        private System.Windows.Forms.Label lblTestersToJob;
    }
}