using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Bookstore4
{
    public partial class Employee : Form
    {
        bool flag;
        public Employee()
        {
            InitializeComponent();
        }

        //open multifunction
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Multifunction multifunction = new Multifunction();
            multifunction.ShowDialog();
            this.Close();

        }

        //back button go to entrance
        private void button1_Click(object sender, EventArgs e)
        {

            //pws na pas pisw se forma kleinontas tin alli xwris na krasharei
            this.Hide();
            Entrance entrance = new Entrance();
            entrance.ShowDialog();
            this.Close();
        }

        //kleisimo/anoigma lampas plus sound effect
        private void pictureBox2_Click(object sender, EventArgs e)
        { 
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Kostas\Desktop\Uni\5o eks\Allilepidrasi\apallaktiki\Sound effects\Light_switch_cropped.wav");
            simpleSound.Play();

            if (flag == false)
            {
                Image myimage = new Bitmap(@"C:\Users\Kostas\Desktop\Uni\5o eks\Allilepidrasi\apallaktiki\Pictures for the bookstore\photoshop\edited\v2\bookstore reading hall2.png");
                this.BackgroundImage = myimage;
                flag = true;
            }
            else
            {
                Image myimage = new Bitmap(@"C:\Users\Kostas\Desktop\Uni\5o eks\Allilepidrasi\apallaktiki\Pictures for the bookstore\photoshop\edited\v2\bookstore reading hall2 lamps on.png");
                this.BackgroundImage = myimage;
                flag = false;
            }
        }
    }
}
