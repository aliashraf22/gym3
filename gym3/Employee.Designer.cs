namespace gym3
{
    partial class Employee
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
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet = new gym3.GymDataSet();
            this.employeeTableAdapter = new gym3.GymDataSetTableAdapters.EmployeeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.companyDataSet1 = new gym3.CompanyDataSet1();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter1 = new gym3.CompanyDataSet1TableAdapters.EmployeeTableAdapter();
            this.companyDataSet = new gym3.CompanyDataSet();
            this.companyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyDataSe5 = new gym3.CompanyDataSe5();
            this.companyDataSe5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new gym3.CompanyDataSe5TableAdapters.MemberTableAdapter();
            this.employeeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter2 = new gym3.CompanyDataSe5TableAdapters.EmployeeTableAdapter();
            this.employeeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.companyDataSe5BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.companyDataSe5BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchRegNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.ssnDataGridViewTextBoxColumn,
            this.eidDataGridViewTextBoxColumn,
            this.branchRegNumDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.depnumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(15, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1587, 309);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.gymDataSet;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 338);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // companyDataSet1
            // 
            this.companyDataSet1.DataSetName = "CompanyDataSet1";
            this.companyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.companyDataSet1;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
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
            // companyDataSe5
            // 
            this.companyDataSe5.DataSetName = "CompanyDataSe5";
            this.companyDataSe5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyDataSe5BindingSource
            // 
            this.companyDataSe5BindingSource.DataSource = this.companyDataSe5;
            this.companyDataSe5BindingSource.Position = 0;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.companyDataSe5;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource2
            // 
            this.employeeBindingSource2.DataMember = "Employee";
            this.employeeBindingSource2.DataSource = this.companyDataSe5;
            // 
            // employeeTableAdapter2
            // 
            this.employeeTableAdapter2.ClearBeforeFill = true;
            // 
            // employeeBindingSource3
            // 
            this.employeeBindingSource3.DataMember = "Employee";
            this.employeeBindingSource3.DataSource = this.companyDataSe5;
            // 
            // companyDataSe5BindingSource1
            // 
            this.companyDataSe5BindingSource1.DataSource = this.companyDataSe5;
            this.companyDataSe5BindingSource1.Position = 0;
            // 
            // companyDataSe5BindingSource2
            // 
            this.companyDataSe5BindingSource2.DataSource = this.companyDataSe5;
            this.companyDataSe5BindingSource2.Position = 0;
            // 
            // employeeBindingSource4
            // 
            this.employeeBindingSource4.DataMember = "Employee";
            this.employeeBindingSource4.DataSource = this.companyDataSe5;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "Lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Lname";
            this.lnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            this.lnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // ssnDataGridViewTextBoxColumn
            // 
            this.ssnDataGridViewTextBoxColumn.DataPropertyName = "Ssn";
            this.ssnDataGridViewTextBoxColumn.HeaderText = "Ssn";
            this.ssnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ssnDataGridViewTextBoxColumn.Name = "ssnDataGridViewTextBoxColumn";
            this.ssnDataGridViewTextBoxColumn.Width = 125;
            // 
            // eidDataGridViewTextBoxColumn
            // 
            this.eidDataGridViewTextBoxColumn.DataPropertyName = "E_id";
            this.eidDataGridViewTextBoxColumn.HeaderText = "E_id";
            this.eidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eidDataGridViewTextBoxColumn.Name = "eidDataGridViewTextBoxColumn";
            this.eidDataGridViewTextBoxColumn.Width = 125;
            // 
            // branchRegNumDataGridViewTextBoxColumn
            // 
            this.branchRegNumDataGridViewTextBoxColumn.DataPropertyName = "BranchRegNum";
            this.branchRegNumDataGridViewTextBoxColumn.HeaderText = "BranchRegNum";
            this.branchRegNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchRegNumDataGridViewTextBoxColumn.Name = "branchRegNumDataGridViewTextBoxColumn";
            this.branchRegNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // depnumDataGridViewTextBoxColumn
            // 
            this.depnumDataGridViewTextBoxColumn.DataPropertyName = "Dep_num";
            this.depnumDataGridViewTextBoxColumn.HeaderText = "Dep_num";
            this.depnumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depnumDataGridViewTextBoxColumn.Name = "depnumDataGridViewTextBoxColumn";
            this.depnumDataGridViewTextBoxColumn.Width = 125;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1743, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private GymDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button button1;
        private CompanyDataSet1 companyDataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private CompanyDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private System.Windows.Forms.BindingSource companyDataSe5BindingSource;
        private CompanyDataSe5 companyDataSe5;
        private CompanyDataSet companyDataSet;
        private System.Windows.Forms.BindingSource companyDataSetBindingSource;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private CompanyDataSe5TableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource2;
        private CompanyDataSe5TableAdapters.EmployeeTableAdapter employeeTableAdapter2;
        private System.Windows.Forms.BindingSource employeeBindingSource3;
        private System.Windows.Forms.BindingSource companyDataSe5BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchRegNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource4;
        private System.Windows.Forms.BindingSource companyDataSe5BindingSource2;
    }
}