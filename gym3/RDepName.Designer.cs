namespace gym3
{
    partial class RDepName
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rbyDepNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet = new gym3.GymDataSet();
            this.rbyDepNameTableAdapter1 = new gym3.GymDataSetTableAdapters.RbyDepNameTableAdapter();
            this.companyDataSe5 = new gym3.CompanyDataSe5();
            this.rDepNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rDepNameTableAdapter = new gym3.CompanyDataSe5TableAdapters.RDepNameTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rbyDepNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDepNameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Department Name";
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reportViewer1.BackgroundImage = global::gym3.Properties.Resources.young_man_sport_gym_club_weight_training_equipment_49718847;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rDepNameBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "gym3.RbyDepName.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 92);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(864, 346);
            this.reportViewer1.TabIndex = 4;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // rbyDepNameBindingSource
            // 
            this.rbyDepNameBindingSource.DataMember = "RbyDepName";
            this.rbyDepNameBindingSource.DataSource = this.gymDataSet;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rbyDepNameTableAdapter1
            // 
            this.rbyDepNameTableAdapter1.ClearBeforeFill = true;
            // 
            // companyDataSe5
            // 
            this.companyDataSe5.DataSetName = "CompanyDataSe5";
            this.companyDataSe5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rDepNameBindingSource
            // 
            this.rDepNameBindingSource.DataMember = "RDepName";
            this.rDepNameBindingSource.DataSource = this.companyDataSe5;
            // 
            // rDepNameTableAdapter
            // 
            this.rDepNameTableAdapter.ClearBeforeFill = true;
            // 
            // RDepName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "RDepName";
            this.Text = "RDepName";
            this.Load += new System.EventHandler(this.RDepName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rbyDepNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDepNameBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private GymDataSetTableAdapters.RbyDepNameTableAdapter rbyDepNameTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rbyDepNameBindingSource;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource rDepNameBindingSource;
        private CompanyDataSe5 companyDataSe5;
        private CompanyDataSe5TableAdapters.RDepNameTableAdapter rDepNameTableAdapter;
    }
}