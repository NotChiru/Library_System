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
    public partial class Library_Menu : Form
    {
        public Library_Menu()
        {
            InitializeComponent();
        }
        Book_Menu books_Menu = new Book_Menu();
        Return_Book return_Book = new Return_Book();
        ViewAccounts_Form viewAccounts_Form = new ViewAccounts_Form();

        void hide_all()
        {
            books_Menu.Hide();
            return_Book.Hide();
        }
        private void Library_Menu_Load(object sender, EventArgs e)
        {
            database.query("select memname from member where member_id = '" + Gvar.Current_User_ID + "'");
            NameLabel.Text = database.returnSingle;

            memidLabel.Text = Gvar.Current_User_ID;

            database.query("SELECT mb.borrow_token, b.ReferenceNumber, b.BookTitle, mb.fee, mb.date_acquire AS DateAcquired, mb.date_return AS ReturnDate FROM manage_borrow mb INNER JOIN bookstable b ON mb.book_code = b.ReferenceNumber WHERE mb.memb_code = '" + Gvar.Current_User_ID + "' and mb.action = 'Book Borrowed' "); Gvar.Borrowed_books_local_table = database.returnTable;

        }

        private void menu_books_Click(object sender, EventArgs e)
        {
            hide_all();
            books_Menu.MdiParent = this;
            books_Menu.Show();
        }

        private void menu_library_Click(object sender, EventArgs e)
        {
            hide_all();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void menu_return_Click(object sender, EventArgs e)
        {
            hide_all();
            return_Book.MdiParent = this;
            return_Book.Show();
        }

        private void Account_Details_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewAccounts_Form.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
