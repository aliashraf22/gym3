using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym3
{
    public partial class Department : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-R515NOIF\\MSSQLSERVER2040;Initial Catalog=Company;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        SqlCommandBuilder cmd;
        public Department()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("select * from Department", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void Department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSe5.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter2.Fill(this.companyDataSe5.Department);
            // TODO: This line of code loads data into the 'companyDataSet2.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter1.Fill(this.companyDataSet2.Department);
            // TODO: This line of code loads data into the 'gymDataSet.Department' table. You can move, or remove it, as needed.
            //this.departmentTableAdapter.Fill(this.gymDataSet.Department);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommandBuilder(Da);
            Da.Update(Dt);
            MessageBox.Show("passed successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
