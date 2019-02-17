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
    public partial class Printer : Form
    {
        For_database for_database = new For_database();
        Scanner form2 = new Scanner();
        Search form3 = new Search();
        public Printer()
            
            
        
        {
            InitializeComponent();
        }
        private void off_Click(object sender, EventArgs e)
        {
            s_off.Visible = false;
            s_off.Enabled = false;
            s_on.Visible = true;
            s_on.Enabled = true;
            button2.Enabled = true;
        }

       
        

        private void s_on_Click(object sender, EventArgs e)
        {
            s_on.Visible = false;
            s_on.Enabled = false;
            s_off.Visible = true;
            s_off.Enabled = true;
            button2.Enabled = false;
        }

        //Exit button,go back to the library
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Employee employee = new Employee();
            employee.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked || radioButton1.Checked)
            {
                MessageBox.Show("Η εκτύπωση ολοκληρώθηκε με επιτυχία!");
            }
            
        }

     
        //query
        private void button3_Click_1(object sender, EventArgs e)
        {
            for_database.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Multifunction multifunction = new Multifunction();
            multifunction.ShowDialog();
            this.Close();
        }
    }
}
