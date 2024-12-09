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

        private void btn_login_Click(object sender, EventArgs e)
        {
            database.query("select password from member where address = '" + txt_email.Text + "'");
            if (database.returnSingle == pwBox.Text) {
                database.query("select member_id from member where address = '" + txt_email.Text + "' and password = '"+pwBox.Text+"'");
                Gvar.Current_User_ID = database.returnSingle;
                database.query("select member from member where member_id = '" + Gvar.Current_User_ID + "'");
                if (database.returnSingle == "Admin")
                {
                    Gvar.CurrentUserIsAdmin = true;
                    this.Hide();
                    library_Menu_Admin.ShowDialog();
                    
                    
                    
                }
                else
                {
                    Gvar.CurrentUserIsAdmin = false;
                    this.Hide();
                    library_Menu.ShowDialog();
                }
            }
            else { MessageBox.Show("Incorrect Email or Password!"); }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_showpass_Click(object sender, EventArgs e)
        {
            if (pwBox.PasswordChar != '\0') { pwBox.PasswordChar = '\0'; }

            else { pwBox.PasswordChar = '*'; }
        }
    }
}
