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
    public partial class Book_Reports : Form
    {
        public Book_Reports()
        {
            InitializeComponent();
        }

        private void menu_books_Click(object sender, EventArgs e)
        {

        }

        private void bookTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_bookDetails_Click(object sender, EventArgs e)
        {
            ViewBooks_Form viewBooks_Form = new ViewBooks_Form();
            viewBooks_Form.ShowDialog();
        }

        private void _process_Tick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Gvar.Account_Manage_Table;
        }

        private void onready(object sender, EventArgs e)
        {
            database.query("select * from member");
            Gvar.Account_Manage_Table = database.returnTable;
        }
    }
}
