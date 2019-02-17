using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Bookstore4
{
    public partial class For_database : Form
    {

        List<string> dataItems = new List<string>();
        public For_database()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PostGreSQL pgTest = new PostGreSQL();
            dataItems = pgTest.PostgreSQLtest1();
            tbDataItems.Clear();
            for (int i = 0; i < dataItems.Count; i++)
            {
                tbDataItems.Text += dataItems[i];
                tbDataItems.ScrollToCaret();
            }
        }
        
    }
}
