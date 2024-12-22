namespace gym3
{
    partial class Branch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.branchnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgrSsnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgrStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.companyDataSe5 = new gym3.CompanyDataSe5();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet = new gym3.GymDataSet();
            this.branchTableAdapter = new gym3.GymDataSetTableAdapters.BranchTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.branchTableAdapter1 = new gym3.CompanyDataSe5TableAdapters.BranchTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.branchnumDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.regNumDataGridViewTextBoxColumn,
            this.mgrSsnDataGridViewTextBoxColumn,
            this.mgrStartDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.branchBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-6, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(989, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // branchnumDataGridViewTextBoxColumn
            // 
            this.branchnumDataGridViewTextBoxColumn.DataPropertyName = "Branch_num";
            this.branchnumDataGridViewTextBoxColumn.HeaderText = "Branch_num";
            this.branchnumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchnumDataGridViewTextBoxColumn.Name = "branchnumDataGridViewTextBoxColumn";
            this.branchnumDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // regNumDataGridViewTextBoxColumn
            // 
            this.regNumDataGridViewTextBoxColumn.DataPropertyName = "RegNum";
            this.regNumDataGridViewTextBoxColumn.HeaderText = "RegNum";
            this.regNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regNumDataGridViewTextBoxColumn.Name = "regNumDataGridViewTextBoxColumn";
            this.regNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // mgrSsnDataGridViewTextBoxColumn
            // 
            this.mgrSsnDataGridViewTextBoxColumn.DataPropertyName = "Mgr_Ssn";
            this.mgrSsnDataGridViewTextBoxColumn.HeaderText = "Mgr_Ssn";
            this.mgrSsnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mgrSsnDataGridViewTextBoxColumn.Name = "mgrSsnDataGridViewTextBoxColumn";
            this.mgrSsnDataGridViewTextBoxColumn.Width = 125;
            // 
            // mgrStartDateDataGridViewTextBoxColumn
            // 
            this.mgrStartDateDataGridViewTextBoxColumn.DataPropertyName = "Mgr_StartDate";
            this.mgrStartDateDataGridViewTextBoxColumn.HeaderText = "Mgr_StartDate";
            this.mgrStartDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mgrStartDateDataGridViewTextBoxColumn.Name = "mgrStartDateDataGridViewTextBoxColumn";
            this.mgrStartDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // branchBindingSource1
            // 
            this.branchBindingSource1.DataMember = "Branch";
            this.branchBindingSource1.DataSource = this.companyDataSe5;
            // 
            // companyDataSe5
            // 
            this.companyDataSe5.DataSetName = "CompanyDataSe5";
            this.companyDataSe5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "Branch";
            this.branchBindingSource.DataSource = this.gymDataSet;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchTableAdapter
            // 
            this.branchTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // branchTableAdapter1
            // 
            this.branchTableAdapter1.ClearBeforeFill = true;
            // 
            // Branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Branch";
            this.Text = "Branch";
            this.Load += new System.EventHandler(this.Branch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private GymDataSetTableAdapters.BranchTableAdapter branchTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mgrSsnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mgrStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private CompanyDataSe5 companyDataSe5;
        private System.Windows.Forms.BindingSource branchBindingSource1;
        private CompanyDataSe5TableAdapters.BranchTableAdapter branchTableAdapter1;
    }
}