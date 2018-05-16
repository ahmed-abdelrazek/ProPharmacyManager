// <copyright>
//     Copyright (C) 2013 ShababConquer Blog.
//     This program is free software; you can redistribute it and/or modify 
//     it under the terms of the GNU General Public License version 2 as 
//     published by the Free Software Foundation.
// 
//     This program is distributed in the hope that it will be useful, but 
//     WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
//     or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License 
//     for more details.
// 
//     You should have received a copy of the GNU General Public License along 
//     with this program; if not, write to the Free Software Foundation, Inc., 
//     51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// </copyright>
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProPharmacyManager
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Face_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.facebook.com/ShababConquer");
        }

        private void Twitter_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.twitter.com/ahmed_master23");
        }

        private void Yahoo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ahmed_master23@yahoo.com");
        }

        private void Blogger_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.shababco.blogspot.com/");
        }
    }
}
