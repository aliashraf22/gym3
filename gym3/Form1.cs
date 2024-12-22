using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void mainEntitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Department d = new Department();
            d.Show();  
        }

        private void rDepNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RDepName RD=new RDepName();
            RD.Show();  
        }

        private void branchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Branch b=new Branch();
            b.Show();
        }

        private void initationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invitation i= new Invitation();
            i.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member m= new Member();
            m.Show();
        }

        private void membershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Membership ms=new Membership();
            ms.Show();
        }

        private void branchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Branch_phone bp=new Branch_phone();
            bp.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
