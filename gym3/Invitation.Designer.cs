namespace gym3
{
    partial class Invitation
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
            this.midDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invitationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.companyDataSe5 = new gym3.CompanyDataSe5();
            this.invitationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet = new gym3.GymDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.invitationTableAdapter = new gym3.GymDataSetTableAdapters.InvitationTableAdapter();
            this.invitationTableAdapter1 = new gym3.CompanyDataSe5TableAdapters.InvitationTableAdapter();
            this.invitationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.invitationBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitationBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.midDataGridViewTextBoxColumn,
            this.inameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.invitationBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(-3, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(805, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // midDataGridViewTextBoxColumn
            // 
            this.midDataGridViewTextBoxColumn.DataPropertyName = "M_id";
            this.midDataGridViewTextBoxColumn.HeaderText = "M_id";
            this.midDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.midDataGridViewTextBoxColumn.Name = "midDataGridViewTextBoxColumn";
            this.midDataGridViewTextBoxColumn.Width = 125;
            // 
            // inameDataGridViewTextBoxColumn
            // 
            this.inameDataGridViewTextBoxColumn.DataPropertyName = "Iname";
            this.inameDataGridViewTextBoxColumn.HeaderText = "Iname";
            this.inameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inameDataGridViewTextBoxColumn.Name = "inameDataGridViewTextBoxColumn";
            this.inameDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // invitationBindingSource1
            // 
            this.invitationBindingSource1.DataMember = "Invitation";
            this.invitationBindingSource1.DataSource = this.companyDataSe5;
            // 
            // companyDataSe5
            // 
            this.companyDataSe5.DataSetName = "CompanyDataSe5";
            this.companyDataSe5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invitationBindingSource
            // 
            this.invitationBindingSource.DataMember = "Invitation";
            this.invitationBindingSource.DataSource = this.gymDataSet;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // invitationTableAdapter
            // 
            this.invitationTableAdapter.ClearBeforeFill = true;
            // 
            // invitationTableAdapter1
            // 
            this.invitationTableAdapter1.ClearBeforeFill = true;
            // 
            // invitationBindingSource2
            // 
            this.invitationBindingSource2.DataMember = "Invitation";
            this.invitationBindingSource2.DataSource = this.companyDataSe5;
            // 
            // invitationBindingSource3
            // 
            this.invitationBindingSource3.DataMember = "Invitation";
            this.invitationBindingSource3.DataSource = this.companyDataSe5;
            // 
            // Invitation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Invitation";
            this.Text = "Invitation";
            this.Load += new System.EventHandler(this.Invitation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitationBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource invitationBindingSource;
        private GymDataSetTableAdapters.InvitationTableAdapter invitationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn midDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private CompanyDataSe5 companyDataSe5;
        private System.Windows.Forms.BindingSource invitationBindingSource1;
        private CompanyDataSe5TableAdapters.InvitationTableAdapter invitationTableAdapter1;
        private System.Windows.Forms.BindingSource invitationBindingSource2;
        private System.Windows.Forms.BindingSource invitationBindingSource3;
    }
}