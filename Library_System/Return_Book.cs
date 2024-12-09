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
    public partial class Return_Book : Form
    {
        public Return_Book()
        {
            InitializeComponent();
        }

        private void btn_bookDetails_Click_1(object sender, EventArgs e)
        {
            if (Gvar.selected_books_to_return != null) {
                database.query("select book_code from manage_borrow where borrow_token = '" + Gvar.selected_books_to_return + "'");
                String temp_refNum = database.returnSingle;

                database.query("select BookTitle from bookstable where ReferenceNumber = '"+temp_refNum+"'");

                string return_message = "Do you want to return this book? \nTitle: "+database.returnSingle;
                DialogResult result = MessageBox.Show(return_message, "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    database.query("update manage_borrow set borrow_token = '" + DateTime.Now.ToString() + "', Action = 'Book Returned' where borrow_token = '" + Gvar.selected_books_to_return + "'");                                   
                    database.query("update bookstable set status = 'Available' where ReferenceNumber = '" + temp_refNum + "'");

                    database.query("SELECT mb.borrow_token, b.ReferenceNumber, b.BookTitle, mb.fee, mb.date_acquire AS DateAcquired, mb.date_return AS ReturnDate FROM manage_borrow mb INNER JOIN bookstable b ON mb.book_code = b.ReferenceNumber WHERE mb.memb_code = '" + Gvar.Current_User_ID + "' and mb.action = 'Book Borrowed' "); Gvar.Borrowed_books_local_table = database.returnTable;
                    database.query("select * from bookstable");
                    Gvar.Book_Menu_Table = database.returnTable;
                }
            }
            
        }

        private void _process_Tick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Gvar.Borrowed_books_local_table;
            float tempval = 0.0f;
            database.query("select borrow_token from manage_borrow where action = 'Book Borrowed' and memb_code = '"+Gvar.Current_User_ID+"'");
            foreach(string strungi in database.returnColumn)
            {
                database.query("select fee from manage_borrow where borrow_token = '" + strungi + "'");
                float temprice = float.Parse(database.returnSingle);

                database.query("select date_return from manage_borrow where borrow_token = '" + strungi + "'");
                int yB = int.Parse(database.returnSingle.Split('/')[2]);
                int dB = int.Parse(database.returnSingle.Split('/')[1]);
                int mB = int.Parse(database.returnSingle.Split('/')[0]);

             
                DateTime date2 = new DateTime(yB, mB, dB);

                Console.WriteLine((DateTime.Now < date2).ToString() + " ");
                

                tempval += temprice;
            }

            total_fee_lapel.Text = Convert.ToDecimal(tempval).ToString("F");
        }

        private void onready(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Gvar.Borrowed_books_local_table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                if (row != null)
                {
                    Gvar.selected_books_to_return = row.Cells["borrow_token"].Value.ToString();

                }
            }
        }
    }
}
