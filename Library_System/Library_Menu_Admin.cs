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
        errorlogger errorlogger = new errorlogger();
        public Library_Menu_Admin()
        {
            InitializeComponent();
        }
        Manage_Book manage_Book = new Manage_Book();
        Manage_Account manage_Account = new Manage_Account();
        Book_Reports book_Reports = new Book_Reports();
        ViewAccounts_Form viewAccounts_Form = new ViewAccounts_Form();

        void hide_all()
        {
            manage_Book.Hide();
            manage_Account.Hide();
            book_Reports.Hide();
        }

        private void Account_Details_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewAccounts_Form.ShowDialog();
        }

        private void menu_books_Click_1(object sender, EventArgs e)
        {
            hide_all();
            manage_Book.MdiParent = this;
            manage_Book.Show();

        }

        private void menu_manageAccounts_Click(object sender, EventArgs e)
        {
            hide_all();
            manage_Account.MdiParent = this;
            manage_Account.Show();
        }

        private void menu_bookReports_Click(object sender, EventArgs e)
        {
            hide_all();
            book_Reports.MdiParent = this;
            book_Reports.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Gvar.CurrentUserIsAdmin = false;
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            else { }
        }

        private void menu_library_Click(object sender, EventArgs e)
        {
            hide_all();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            database.DEBUG_MODE_IS_ENABLED = checkBox1.Checked;
        }

        private void onready(object sender, EventArgs e)
        {

            checkBox1.Checked = database.DEBUG_MODE_IS_ENABLED;
            database.query("select memname from member where member_id = '" + Gvar.Current_User_ID + "'");
            NameLabel.Text = database.returnSingle;

            database.query("SELECT mb.borrow_token, b.ReferenceNumber, b.BookTitle, mb.fee, mb.date_acquire AS DateAcquired, mb.date_return AS ReturnDate FROM manage_borrow mb INNER JOIN bookstable b ON mb.book_code = b.ReferenceNumber WHERE mb.memb_code = '" + Gvar.Current_User_ID + "' and mb.action = 'Book Borrowed' "); Gvar.Borrowed_books_local_table = database.returnTable;


            memidLabel.Text = Gvar.Current_User_ID;
        }
    }
}
