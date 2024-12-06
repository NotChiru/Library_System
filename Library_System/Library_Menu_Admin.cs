using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class Library_Menu_Admin : Form
    {
        public Library_Menu_Admin()
        {
            InitializeComponent();
        }
        Manage_Book manage_Book = new Manage_Book();
        private void menu_library_Click(object sender, EventArgs e)
        {

        }

        private void Account_Details_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void menu_books_Click_1(object sender, EventArgs e)
        {
            manage_Book.MdiParent = this;
            manage_Book.Show();

        }
    }
}
