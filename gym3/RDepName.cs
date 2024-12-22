using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace gym3
{
    public partial class RDepName : Form
    {
        public RDepName()
        {
            InitializeComponent();
        }

        private void RDepName_Load(object sender, EventArgs e)
        {

           //GymDataSet gymDataSet = new GymDataSet();

            //GymDataSetTableAdapters.RbyDepNameTableAdapter RbyDepNameTableAdapter =
               // new GymDataSetTableAdapters.RbyDepNameTableAdapter();

            //RbyDepNameTableAdapter.FillbyDep_name(GymDataSet.RbyDepName);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.rDepNameTableAdapter.Fill(this.companyDataSe5.RDepName,textBox1.Text);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
