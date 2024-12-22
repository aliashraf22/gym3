namespace gym3
{
    partial class Branch_phone
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
            this.branchphoneBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.companyDataSe5 = new gym3.CompanyDataSe5();
            this.branchphoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet = new gym3.GymDataSet();
            this.branch_phoneTableAdapter = new gym3.GymDataSetTableAdapters.Branch_phoneTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.companyDataSe5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branch_phoneTableAdapter1 = new gym3.CompanyDataSe5TableAdapters.Branch_phoneTableAdapter();
            this.companyDataSe5BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.branchphoneBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.regNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchphoneBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchphoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchphoneBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regNumDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.branchphoneBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(-3, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // branchphoneBindingSource1
            // 
            this.branchphoneBindingSource1.DataMember = "Branch_phone";
            this.branchphoneBindingSource1.DataSource = this.companyDataSe5;
            // 
            // companyDataSe5
            // 
            this.companyDataSe5.DataSetName = "CompanyDataSe5";
            this.companyDataSe5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchphoneBindingSource
            // 
            this.branchphoneBindingSource.DataMember = "Branch_phone";
            this.branchphoneBindingSource.DataSource = this.gymDataSet;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branch_phoneTableAdapter
            // 
            this.branch_phoneTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // companyDataSe5BindingSource
            // 
            this.companyDataSe5BindingSource.DataSource = this.companyDataSe5;
            this.companyDataSe5BindingSource.Position = 0;
            // 
            // branch_phoneTableAdapter1
            // 
            this.branch_phoneTableAdapter1.ClearBeforeFill = true;
            // 
            // companyDataSe5BindingSource1
            // 
            this.companyDataSe5BindingSource1.DataSource = this.companyDataSe5;
            this.companyDataSe5BindingSource1.Position = 0;
            // 
            // branchphoneBindingSource2
            // 
            this.branchphoneBindingSource2.DataMember = "Branch_phone";
            this.branchphoneBindingSource2.DataSource = this.companyDataSe5;
            // 
            // regNumDataGridViewTextBoxColumn
            // 
            this.regNumDataGridViewTextBoxColumn.DataPropertyName = "RegNum";
            this.regNumDataGridViewTextBoxColumn.HeaderText = "RegNum";
            this.regNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regNumDataGridViewTextBoxColumn.Name = "regNumDataGridViewTextBoxColumn";
            this.regNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // Branch_phone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Branch_phone";
            this.Text = "Branch_phone";
            this.Load += new System.EventHandler(this.Branch_phone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchphoneBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchphoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchphoneBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource branchphoneBindingSource;
        private GymDataSetTableAdapters.Branch_phoneTableAdapter branch_phoneTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource companyDataSe5BindingSource;
        private CompanyDataSe5 companyDataSe5;
        private System.Windows.Forms.BindingSource branchphoneBindingSource1;
        private CompanyDataSe5TableAdapters.Branch_phoneTableAdapter branch_phoneTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource branchphoneBindingSource2;
        private System.Windows.Forms.BindingSource companyDataSe5BindingSource1;
    }
}