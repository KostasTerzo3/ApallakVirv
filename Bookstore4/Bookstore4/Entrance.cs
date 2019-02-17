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
    public partial class Entrance : Form
    {

        public Entrance()
        {
            InitializeComponent();

        }

        //employee
        private void button1_Click(object sender, EventArgs e)
        {
            //pws na anoikseis mia kainouria forma kleinontas tin alli xwris na krasharei
            this.Hide();
            Employee employee = new Employee();
            employee.ShowDialog();
            this.Close();
        }

        //customer
        private void button2_Click(object sender, EventArgs e)
        {

            //pws na anoikseis mia kainouria forma kleinontas tin alli xwris na krasharei
            this.Hide();
            Customer customer = new Customer();
            customer.ShowDialog();
            this.Close();
        }
    }
}
