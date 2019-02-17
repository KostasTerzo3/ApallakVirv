using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore4
{
    public partial class Scanner : Form
    {
        public Scanner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η σάρωση ολοκληρώθηκε!");
        }

        private void s_off_Click(object sender, EventArgs e)
        {
            s_off.Visible = false;
            s_off.Enabled = false;
            s_on.Visible = true;
            s_on.Enabled = true;
            button3.Enabled = true;
        }

        private void s_on_Click(object sender, EventArgs e)
        {
            s_on.Visible = false;
            s_on.Enabled = false;
            s_off.Visible = true;
            s_off.Enabled = true;
            button3.Enabled = false;
        }

        //choose an other mode
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Multifunction multifunction = new Multifunction();
            multifunction.ShowDialog();
            this.Close();
        }

        //exit button go back to the library
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee employee = new Employee();
            employee.ShowDialog();
            this.Close();
        }
    }
}
