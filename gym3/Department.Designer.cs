namespace gym3
{
    partial class Department
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
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet = new gym3.GymDataSet();
            this.departmentTableAdapter = new gym3.GymDataSetTableAdapters.DepartmentTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.companyDataSet2 = new gym3.CompanyDataSet2();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter1 = new gym3.CompanyDataSet2TableAdapters.DepartmentTableAdapter();
            this.companyDataSet = new gym3.CompanyDataSet();
            this.companyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyDataSet1 = new gym3.CompanyDataSet1();
            this.companyDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyDataSe5 = new gym3.CompanyDataSe5();
            this.departmentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter2 = new gym3.CompanyDataSe5TableAdapters.DepartmentTableAdapter();
            this.depnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depnumDataGridViewTextBoxColumn,
            this.depnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.departmentBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 276);
            this.dataGridView1.TabIndex = 0;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.gymDataSet;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // companyDataSet2
            // 
            this.companyDataSet2.DataSetName = "CompanyDataSet2";
            this.companyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataMember = "Department";
            this.departmentBindingSource1.DataSource = this.companyDataSet2;
            // 
            // departmentTableAdapter1
            // 
            this.departmentTableAdapter1.ClearBeforeFill = true;
            // 
            // companyDataSet
            // 
            this.companyDataSet.DataSetName = "CompanyDataSet";
            this.companyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyDataSetBindingSource
            // 
            this.companyDataSetBindingSource.DataSource = this.companyDataSet;
            this.companyDataSetBindingSource.Position = 0;
            // 
            // companyDataSet1
            // 
            this.companyDataSet1.DataSetName = "CompanyDataSet1";
            this.companyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyDataSet1BindingSource
            // 
            this.companyDataSet1BindingSource.DataSource = this.companyDataSet1;
            this.companyDataSet1BindingSource.Position = 0;
            // 
            // companyDataSe5
            // 
            this.companyDataSe5.DataSetName = "CompanyDataSe5";
            this.companyDataSe5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource2
            // 
            this.departmentBindingSource2.DataMember = "Department";
            this.departmentBindingSource2.DataSource = this.companyDataSe5;
            // 
            // departmentTableAdapter2
            // 
            this.departmentTableAdapter2.ClearBeforeFill = true;
            // 
            // depnumDataGridViewTextBoxColumn
            // 
            this.depnumDataGridViewTextBoxColumn.DataPropertyName = "Dep_num";
            this.depnumDataGridViewTextBoxColumn.HeaderText = "Dep_num";
            this.depnumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depnumDataGridViewTextBoxColumn.Name = "depnumDataGridViewTextBoxColumn";
            this.depnumDataGridViewTextBoxColumn.Width = 125;
            // 
            // depnameDataGridViewTextBoxColumn
            // 
            this.depnameDataGridViewTextBoxColumn.DataPropertyName = "Dep_name";
            this.depnameDataGridViewTextBoxColumn.HeaderText = "Dep_name";
            this.depnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depnameDataGridViewTextBoxColumn.Name = "depnameDataGridViewTextBoxColumn";
            this.depnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Department";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private GymDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.Button button1;
        private CompanyDataSet2 companyDataSet2;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private CompanyDataSet2TableAdapters.DepartmentTableAdapter departmentTableAdapter1;
        private System.Windows.Forms.BindingSource companyDataSet1BindingSource;
        private CompanyDataSet1 companyDataSet1;
        private CompanyDataSet companyDataSet;
        private System.Windows.Forms.BindingSource companyDataSetBindingSource;
        private CompanyDataSe5 companyDataSe5;
        private System.Windows.Forms.BindingSource departmentBindingSource2;
        private CompanyDataSe5TableAdapters.DepartmentTableAdapter departmentTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn depnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depnameDataGridViewTextBoxColumn;
    }
}