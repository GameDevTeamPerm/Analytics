namespace IT_manager
{
    partial class DeploymentForm
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
            this.gbTestingRequirements = new System.Windows.Forms.GroupBox();
            this.tvNewRequirements = new System.Windows.Forms.TreeView();
            this.lblNewRequirements = new System.Windows.Forms.Label();
            this.btnNextIteration = new System.Windows.Forms.Button();
            this.lblReportDeployment = new System.Windows.Forms.Label();
            this.dgvReportErrors = new System.Windows.Forms.DataGridView();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.cbSelectStakeholder = new System.Windows.Forms.ComboBox();
            this.lblSelectStakeholder = new System.Windows.Forms.Label();
            this.gbListRequirements = new System.Windows.Forms.GroupBox();
            this.btnListRequirements = new System.Windows.Forms.Button();
            this.tvCurrentListRequirements = new System.Windows.Forms.TreeView();
            this.gbTestingRequirements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportErrors)).BeginInit();
            this.gbListRequirements.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTestingRequirements
            // 
            this.gbTestingRequirements.Controls.Add(this.tvNewRequirements);
            this.gbTestingRequirements.Controls.Add(this.lblNewRequirements);
            this.gbTestingRequirements.Controls.Add(this.btnNextIteration);
            this.gbTestingRequirements.Controls.Add(this.lblReportDeployment);
            this.gbTestingRequirements.Controls.Add(this.dgvReportErrors);
            this.gbTestingRequirements.Controls.Add(this.btnShowReport);
            this.gbTestingRequirements.Controls.Add(this.cbSelectStakeholder);
            this.gbTestingRequirements.Controls.Add(this.lblSelectStakeholder);
            this.gbTestingRequirements.Location = new System.Drawing.Point(26, 44);
            this.gbTestingRequirements.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbTestingRequirements.Name = "gbTestingRequirements";
            this.gbTestingRequirements.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbTestingRequirements.Size = new System.Drawing.Size(770, 856);
            this.gbTestingRequirements.TabIndex = 0;
            this.gbTestingRequirements.TabStop = false;
            this.gbTestingRequirements.Text = "Тестирование на соответствие требованиям";
            // 
            // tvNewRequirements
            // 
            this.tvNewRequirements.Location = new System.Drawing.Point(20, 600);
            this.tvNewRequirements.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tvNewRequirements.Name = "tvNewRequirements";
            this.tvNewRequirements.Size = new System.Drawing.Size(686, 183);
            this.tvNewRequirements.TabIndex = 7;
            // 
            // lblNewRequirements
            // 
            this.lblNewRequirements.AutoSize = true;
            this.lblNewRequirements.Location = new System.Drawing.Point(18, 569);
            this.lblNewRequirements.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewRequirements.Name = "lblNewRequirements";
            this.lblNewRequirements.Size = new System.Drawing.Size(260, 25);
            this.lblNewRequirements.TabIndex = 6;
            this.lblNewRequirements.Text = "Выявленные требования";
            // 
            // btnNextIteration
            // 
            this.btnNextIteration.Location = new System.Drawing.Point(438, 800);
            this.btnNextIteration.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNextIteration.Name = "btnNextIteration";
            this.btnNextIteration.Size = new System.Drawing.Size(276, 44);
            this.btnNextIteration.TabIndex = 5;
            this.btnNextIteration.Text = "Следующая итерация";
            this.btnNextIteration.UseVisualStyleBackColor = true;
            this.btnNextIteration.Click += new System.EventHandler(this.btnNextIteration_Click);
            // 
            // lblReportDeployment
            // 
            this.lblReportDeployment.AutoSize = true;
            this.lblReportDeployment.Location = new System.Drawing.Point(18, 223);
            this.lblReportDeployment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReportDeployment.Name = "lblReportDeployment";
            this.lblReportDeployment.Size = new System.Drawing.Size(438, 25);
            this.lblReportDeployment.TabIndex = 4;
            this.lblReportDeployment.Text = "Отчет по развертыванию от стейкхолдера";
            // 
            // dgvReportErrors
            // 
            this.dgvReportErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportErrors.Location = new System.Drawing.Point(24, 254);
            this.dgvReportErrors.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvReportErrors.Name = "dgvReportErrors";
            this.dgvReportErrors.ReadOnly = true;
            this.dgvReportErrors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportErrors.Size = new System.Drawing.Size(690, 279);
            this.dgvReportErrors.TabIndex = 3;
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(20, 173);
            this.btnShowReport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(242, 44);
            this.btnShowReport.TabIndex = 2;
            this.btnShowReport.Text = "Показать";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // cbSelectStakeholder
            // 
            this.cbSelectStakeholder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectStakeholder.FormattingEnabled = true;
            this.cbSelectStakeholder.Items.AddRange(new object[] {
            "Заказчик",
            "Пользователь"});
            this.cbSelectStakeholder.Location = new System.Drawing.Point(20, 85);
            this.cbSelectStakeholder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbSelectStakeholder.Name = "cbSelectStakeholder";
            this.cbSelectStakeholder.Size = new System.Drawing.Size(238, 33);
            this.cbSelectStakeholder.TabIndex = 1;
            // 
            // lblSelectStakeholder
            // 
            this.lblSelectStakeholder.AutoSize = true;
            this.lblSelectStakeholder.Location = new System.Drawing.Point(14, 52);
            this.lblSelectStakeholder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSelectStakeholder.Name = "lblSelectStakeholder";
            this.lblSelectStakeholder.Size = new System.Drawing.Size(243, 25);
            this.lblSelectStakeholder.TabIndex = 0;
            this.lblSelectStakeholder.Text = "Выбрать стейкхолдера";
            // 
            // gbListRequirements
            // 
            this.gbListRequirements.Controls.Add(this.btnListRequirements);
            this.gbListRequirements.Controls.Add(this.tvCurrentListRequirements);
            this.gbListRequirements.Location = new System.Drawing.Point(840, 44);
            this.gbListRequirements.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbListRequirements.Name = "gbListRequirements";
            this.gbListRequirements.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbListRequirements.Size = new System.Drawing.Size(466, 594);
            this.gbListRequirements.TabIndex = 1;
            this.gbListRequirements.TabStop = false;
            this.gbListRequirements.Text = "Список требований";
            // 
            // btnListRequirements
            // 
            this.btnListRequirements.Location = new System.Drawing.Point(42, 387);
            this.btnListRequirements.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnListRequirements.Name = "btnListRequirements";
            this.btnListRequirements.Size = new System.Drawing.Size(382, 44);
            this.btnListRequirements.TabIndex = 1;
            this.btnListRequirements.Text = "Обновить список требований";
            this.btnListRequirements.UseVisualStyleBackColor = true;
            // 
            // tvCurrentListRequirements
            // 
            this.tvCurrentListRequirements.Location = new System.Drawing.Point(14, 38);
            this.tvCurrentListRequirements.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tvCurrentListRequirements.Name = "tvCurrentListRequirements";
            this.tvCurrentListRequirements.Size = new System.Drawing.Size(436, 333);
            this.tvCurrentListRequirements.TabIndex = 0;
            // 
            // DeploymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 956);
            this.Controls.Add(this.gbListRequirements);
            this.Controls.Add(this.gbTestingRequirements);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DeploymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Развертывание";
            this.gbTestingRequirements.ResumeLayout(false);
            this.gbTestingRequirements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportErrors)).EndInit();
            this.gbListRequirements.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTestingRequirements;
        private System.Windows.Forms.Label lblSelectStakeholder;
        private System.Windows.Forms.GroupBox gbListRequirements;
        private System.Windows.Forms.DataGridView dgvReportErrors;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.ComboBox cbSelectStakeholder;
        private System.Windows.Forms.Label lblReportDeployment;
        private System.Windows.Forms.Button btnNextIteration;
        private System.Windows.Forms.Button btnListRequirements;
        private System.Windows.Forms.TreeView tvCurrentListRequirements;
        private System.Windows.Forms.Label lblNewRequirements;
        private System.Windows.Forms.TreeView tvNewRequirements;
    }
}