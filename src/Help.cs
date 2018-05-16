using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PharmacyProManager
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.facebook.com/ShababConquer");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.twitter.com/ahmed_master23");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.shababco.blogspot.com/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ahmed_master23@yahoo.com");
        }
    }
}
