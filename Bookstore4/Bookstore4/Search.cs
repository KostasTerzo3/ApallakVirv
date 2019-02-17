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
    public partial class Search : Form
    {


        public Search()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    var item = listView1.SelectedItems[0];
                    var img = item.ImageList.Images[item.ImageIndex];

                    pictureBox1.Image = img;

                }

                String text = listView1.SelectedItems[0].Text;
                richTextBox1.Text = text;
            }
            catch  { }
        
            
            // pictureBox1.Image ='';
        }
    }
}
