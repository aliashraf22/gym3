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
    public partial class Membership : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-R515NOIF\\MSSQLSERVER2040;Initial Catalog=Company;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        SqlCommandBuilder cmd;
        public Membership()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("select * from Membership", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void Membership_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSe5.Membership' table. You can move, or remove it, as needed.
            this.membershipTableAdapter1.Fill(this.companyDataSe5.Membership);
            // TODO: This line of code loads data into the 'gymDataSet.Membership' table. You can move, or remove it, as needed.
           // this.membershipTableAdapter.Fill(this.gymDataSet.Membership);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommandBuilder(Da);
            Da.Update(Dt);
            MessageBox.Show("passed successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
