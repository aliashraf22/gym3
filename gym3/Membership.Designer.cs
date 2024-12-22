﻿namespace gym3
{
    partial class Membership
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
            this.regNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.companyDataSe5 = new gym3.CompanyDataSe5();
            this.membershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet = new gym3.GymDataSet();
            this.membershipTableAdapter = new gym3.GymDataSetTableAdapters.MembershipTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.membershipTableAdapter1 = new gym3.CompanyDataSe5TableAdapters.MembershipTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.midDataGridViewTextBoxColumn,
            this.regNumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.membershipBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-6, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(806, 291);
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
            // regNumDataGridViewTextBoxColumn
            // 
            this.regNumDataGridViewTextBoxColumn.DataPropertyName = "RegNum";
            this.regNumDataGridViewTextBoxColumn.HeaderText = "RegNum";
            this.regNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regNumDataGridViewTextBoxColumn.Name = "regNumDataGridViewTextBoxColumn";
            this.regNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // membershipBindingSource1
            // 
            this.membershipBindingSource1.DataMember = "Membership";
            this.membershipBindingSource1.DataSource = this.companyDataSe5;
            // 
            // companyDataSe5
            // 
            this.companyDataSe5.DataSetName = "CompanyDataSe5";
            this.companyDataSe5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membershipBindingSource
            // 
            this.membershipBindingSource.DataMember = "Membership";
            this.membershipBindingSource.DataSource = this.gymDataSet;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membershipTableAdapter
            // 
            this.membershipTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // membershipTableAdapter1
            // 
            this.membershipTableAdapter1.ClearBeforeFill = true;
            // 
            // Membership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Membership";
            this.Text = "Membership";
            this.Load += new System.EventHandler(this.Membership_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSe5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource membershipBindingSource;
        private GymDataSetTableAdapters.MembershipTableAdapter membershipTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn midDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private CompanyDataSe5 companyDataSe5;
        private System.Windows.Forms.BindingSource membershipBindingSource1;
        private CompanyDataSe5TableAdapters.MembershipTableAdapter membershipTableAdapter1;
    }
}