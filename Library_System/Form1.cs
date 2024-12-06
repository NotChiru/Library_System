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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Library_Menu_Admin library_Menu_Admin = new Library_Menu_Admin();
        Library_Menu library_Menu = new Library_Menu();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menu_books_Click(object sender, EventArgs e)
        {

        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "admin")
            {
                this.Hide();
                library_Menu_Admin.ShowDialog();
            }
            else
            {
                
                this.Hide();
                library_Menu.ShowDialog();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
