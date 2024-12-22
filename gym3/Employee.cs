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

namespace gym3
{
    public partial class Employee : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-R515NOIF\\MSSQLSERVER2040;Initial Catalog=Company;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt =new DataTable();
        SqlCommandBuilder cmd;
        public Employee()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("select * from Employee",con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;




        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSe5.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter2.Fill(this.companyDataSe5.Employee);
            // TODO: This line of code loads data into the 'companyDataSe5.Member' table. You can move, or remove it, as needed.
           // this.memberTableAdapter.Fill(this.companyDataSe5.Member);
            // TODO: This line of code loads data into the 'companyDataSet1.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter1.Fill(this.companyDataSet1.Employee);
            // TODO: This line of code loads data into the 'gymDataSet.Employee' table. You can move, or remove it, as needed.
           // this.employeeTableAdapter.Fill(this.gymDataSet.Employee);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(Da);
            Da.Update(Dt);
            MessageBox.Show("passed successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
