using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_System
{
    public partial class ViewBooks_Form : Form
    {
        float finalpriz = 0.0f;
        DateTime FutureDate = DateTime.Now;
        public ViewBooks_Form()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            database.query("select member from member where member_id = '" +Gvar.Current_User_ID+"'");
            switch (database.returnSingle)
            {
                case "Student":
                    finalpriz = 100 - (100 * 0.15f);
                    break;

                case "Regular":
                    finalpriz = 100;
                    break;

                default:
                break;
            }
            

            String SerialNow = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Year.ToString();
            String SerialFuture = FutureDate.Month.ToString() + "/" + FutureDate.Day.ToString() + "/" + FutureDate.Year.ToString();
            database.query("update bookstable set status = 'Borrowed' where ReferenceNumber = '" + Gvar.BookManager_SelectedID + "'");
            database.query("insert into manage_borrow values ('"+DateTime.Now.ToString()+"','Book Borrowed','" + Gvar.BookManager_SelectedID + "','" + Gvar.Current_User_ID + "','" + finalpriz.ToString() + "','" + SerialFuture + "','" + SerialNow + "')");
            database.query("select * from bookstable");
            Gvar.Book_Menu_Table = database.returnTable;

            database.query("SELECT mb.borrow_token, b.ReferenceNumber, b.BookTitle, mb.fee, mb.date_acquire AS DateAcquired, mb.date_return AS ReturnDate FROM manage_borrow mb INNER JOIN bookstable b ON mb.book_code = b.ReferenceNumber WHERE mb.memb_code = '" + Gvar.Current_User_ID + "' and mb.action = 'Book Borrowed' "); Gvar.Borrowed_books_local_table = database.returnTable;


            MessageBox.Show("Book Borrowed\n\nBorrowed at: "+SerialNow+"\n"+ "Return in: "+SerialFuture);
            this.Close();
        }

        private void ViewBooks_Form_Load(object sender, EventArgs e)
        {

        }

        private void onready(object sender, EventArgs e)
        {
            FutureDate = DateTime.Now.AddDays(14);
            database.query("select booktitle from bookstable where ReferenceNumber = '" + Gvar.BookManager_SelectedID + "'");
            txt_title.Text = database.returnSingle;
            database.query("select author from bookstable where ReferenceNumber = '" + Gvar.BookManager_SelectedID + "'");
            txt_author.Text = database.returnSingle;
            database.query("select category from bookstable where ReferenceNumber = '" + Gvar.BookManager_SelectedID + "'");
            txt_category.Text = database.returnSingle;
            database.query("select booktype from bookstable where ReferenceNumber = '" + Gvar.BookManager_SelectedID + "'");
            txt_bookType.Text = database.returnSingle;
            database.query("select printtype from mebookstablember where ReferenceNumber = '" + Gvar.BookManager_SelectedID + "'");
            txt_bookType.Text += database.returnSingle;
            database.query("select PublishingDate from bookstable where ReferenceNumber = '" + Gvar.BookManager_SelectedID + "'");
            txt_dateAdded.Text = database.returnSingle;
            txt_refNo.Text = Gvar.BookManager_SelectedID;
            database.query("select Copyright from bookstable where ReferenceNumber = '" + Gvar.BookManager_SelectedID + "'");
            txt_dateAdded.Text = database.returnSingle;



            database.query("select status from bookstable where ReferenceNumber = '"+Gvar.BookManager_SelectedID + "'");
            borrow_labe.Text =  "Book is currently " + database.returnSingle;
            btn_borrow.Enabled = !Gvar.CurrentUserIsAdmin && database.returnSingle == "Available";
            btn_borrow.Visible = !Gvar.CurrentUserIsAdmin && database.returnSingle == "Available";

            

        }
    }
}
