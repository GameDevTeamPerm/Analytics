namespace IT_manager
{
    partial class StabilizationForm
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
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblTests = new System.Windows.Forms.Label();
            this.lblListOfJobs = new System.Windows.Forms.Label();
            this.btnJobsSelection = new System.Windows.Forms.Button();
            this.btnStabilization = new System.Windows.Forms.Button();
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.dgvListOfJobs = new System.Windows.Forms.DataGridView();
            this.gbStabilization = new System.Windows.Forms.GroupBox();
            this.gbTesting = new System.Windows.Forms.GroupBox();
            this.btnStartDeployment = new System.Windows.Forms.Button();
            this.lblResulttOfReport = new System.Windows.Forms.Label();
            this.lblResultOfReport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfJobs)).BeginInit();
            this.gbStabilization.SuspendLayout();
            this.gbTesting.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(18, 62);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(840, 288);
            this.dgvReport.TabIndex = 2;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(12, 31);
            this.lblReport.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(63, 25);
            this.lblReport.TabIndex = 3;
            this.lblReport.Text = "План";
            // 
            // lblTests
            // 
            this.lblTests.AutoSize = true;
            this.lblTests.Location = new System.Drawing.Point(12, 31);
            this.lblTests.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTests.Name = "lblTests";
            this.lblTests.Size = new System.Drawing.Size(73, 25);
            this.lblTests.TabIndex = 4;
            this.lblTests.Text = "Тесты";
            // 
            // lblListOfJobs
            // 
            this.lblListOfJobs.AutoSize = true;
            this.lblListOfJobs.Location = new System.Drawing.Point(16, 412);
            this.lblListOfJobs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblListOfJobs.Name = "lblListOfJobs";
            this.lblListOfJobs.Size = new System.Drawing.Size(149, 25);
            this.lblListOfJobs.TabIndex = 5;
            this.lblListOfJobs.Text = "Список работ";
            // 
            // btnJobsSelection
            // 
            this.btnJobsSelection.Location = new System.Drawing.Point(594, 740);
            this.btnJobsSelection.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnJobsSelection.Name = "btnJobsSelection";
            this.btnJobsSelection.Size = new System.Drawing.Size(236, 44);
            this.btnJobsSelection.TabIndex = 6;
            this.btnJobsSelection.Text = "Добавить тесты";
            this.btnJobsSelection.UseVisualStyleBackColor = true;
            this.btnJobsSelection.Click += new System.EventHandler(this.btnJobsSelection_Click);
            // 
            // btnStabilization
            // 
            this.btnStabilization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStabilization.Location = new System.Drawing.Point(472, 371);
            this.btnStabilization.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnStabilization.Name = "btnStabilization";
            this.btnStabilization.Size = new System.Drawing.Size(386, 44);
            this.btnStabilization.TabIndex = 7;
            this.btnStabilization.Text = "Выполнить стабилизацию";
            this.btnStabilization.UseVisualStyleBackColor = true;
            this.btnStabilization.Click += new System.EventHandler(this.btnStabilization_Click);
            // 
            // dgvTests
            // 
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTests.Location = new System.Drawing.Point(20, 62);
            this.dgvTests.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.ReadOnly = true;
            this.dgvTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTests.Size = new System.Drawing.Size(810, 288);
            this.dgvTests.TabIndex = 0;
            // 
            // dgvListOfJobs
            // 
            this.dgvListOfJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOfJobs.Location = new System.Drawing.Point(22, 442);
            this.dgvListOfJobs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvListOfJobs.Name = "dgvListOfJobs";
            this.dgvListOfJobs.ReadOnly = true;
            this.dgvListOfJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListOfJobs.Size = new System.Drawing.Size(808, 287);
            this.dgvListOfJobs.TabIndex = 1;
            // 
            // gbStabilization
            // 
            this.gbStabilization.Controls.Add(this.dgvTests);
            this.gbStabilization.Controls.Add(this.btnJobsSelection);
            this.gbStabilization.Controls.Add(this.lblTests);
            this.gbStabilization.Controls.Add(this.dgvListOfJobs);
            this.gbStabilization.Controls.Add(this.lblListOfJobs);
            this.gbStabilization.Location = new System.Drawing.Point(6, 4);
            this.gbStabilization.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbStabilization.Name = "gbStabilization";
            this.gbStabilization.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbStabilization.Size = new System.Drawing.Size(842, 798);
            this.gbStabilization.TabIndex = 8;
            this.gbStabilization.TabStop = false;
            this.gbStabilization.Text = "Стабилизация";
            // 
            // gbTesting
            // 
            this.gbTesting.Controls.Add(this.btnStartDeployment);
            this.gbTesting.Controls.Add(this.lblResulttOfReport);
            this.gbTesting.Controls.Add(this.lblResultOfReport);
            this.gbTesting.Controls.Add(this.lblReport);
            this.gbTesting.Controls.Add(this.dgvReport);
            this.gbTesting.Controls.Add(this.btnStabilization);
            this.gbTesting.Location = new System.Drawing.Point(860, 4);
            this.gbTesting.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbTesting.Name = "gbTesting";
            this.gbTesting.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbTesting.Size = new System.Drawing.Size(884, 798);
            this.gbTesting.TabIndex = 9;
            this.gbTesting.TabStop = false;
            this.gbTesting.Text = "Тестирование";
            // 
            // btnStartDeployment
            // 
            this.btnStartDeployment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartDeployment.Location = new System.Drawing.Point(472, 740);
            this.btnStartDeployment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnStartDeployment.Name = "btnStartDeployment";
            this.btnStartDeployment.Size = new System.Drawing.Size(386, 44);
            this.btnStartDeployment.TabIndex = 10;
            this.btnStartDeployment.Text = "Перейти на этап развертывания";
            this.btnStartDeployment.UseVisualStyleBackColor = true;
            this.btnStartDeployment.Click += new System.EventHandler(this.btnStartDeployment_Click);
            // 
            // lblResulttOfReport
            // 
            this.lblResulttOfReport.AutoSize = true;
            this.lblResulttOfReport.Location = new System.Drawing.Point(32, 408);
            this.lblResulttOfReport.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResulttOfReport.Name = "lblResulttOfReport";
            this.lblResulttOfReport.Size = new System.Drawing.Size(115, 25);
            this.lblResulttOfReport.TabIndex = 9;
            this.lblResulttOfReport.Text = "Результат";
            // 
            // lblResultOfReport
            // 
            this.lblResultOfReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultOfReport.AutoSize = true;
            this.lblResultOfReport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResultOfReport.Location = new System.Drawing.Point(32, 442);
            this.lblResultOfReport.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResultOfReport.MaximumSize = new System.Drawing.Size(1100, 288);
            this.lblResultOfReport.MinimumSize = new System.Drawing.Size(1100, 288);
            this.lblResultOfReport.Name = "lblResultOfReport";
            this.lblResultOfReport.Size = new System.Drawing.Size(1100, 288);
            this.lblResultOfReport.TabIndex = 8;
            // 
            // StabilizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1762, 827);
            this.Controls.Add(this.gbTesting);
            this.Controls.Add(this.gbStabilization);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "StabilizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стабилизация";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfJobs)).EndInit();
            this.gbStabilization.ResumeLayout(false);
            this.gbStabilization.PerformLayout();
            this.gbTesting.ResumeLayout(false);
            this.gbTesting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblTests;
        private System.Windows.Forms.Label lblListOfJobs;
        private System.Windows.Forms.Button btnJobsSelection;
        private System.Windows.Forms.Button btnStabilization;
        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.DataGridView dgvListOfJobs;
        private System.Windows.Forms.GroupBox gbStabilization;
        private System.Windows.Forms.GroupBox gbTesting;
        private System.Windows.Forms.Label lblResulttOfReport;
        private System.Windows.Forms.Label lblResultOfReport;
        private System.Windows.Forms.Button btnStartDeployment;
    }
}