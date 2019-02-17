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
    public partial class Multifunction : Form
    {
        public Multifunction()
        {
            InitializeComponent();
        }

        //open the printer
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Printer printer = new Printer();
            printer.ShowDialog();
            this.Close();
        }

        //open the scanner
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Scanner scanner = new Scanner();
            scanner.ShowDialog();
            this.Close();
        }

        //go back to the library
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee employee = new Employee();
            employee.ShowDialog();
            this.Close();
        }
    }
}
