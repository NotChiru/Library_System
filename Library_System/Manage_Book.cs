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
    public partial class Manage_Book : Form
    {


        public Manage_Book()
        {
            InitializeComponent();
        }
        ViewBooks_Form viewBooks_Form = new ViewBooks_Form();


        private void btn_bookDetails_Click(object sender, EventArgs e)
        {
            if (Gvar.BookManager_SelectedID != null)
            {
                viewBooks_Form.ShowDialog();
            } else { MessageBox.Show("No Books Selected!"); }
        }

        private void onready(object sender, EventArgs e)
        {
            database.query("select * from bookstable");
            Gvar.Book_Menu_Table = database.returnTable;

           
            foreach(DataColumn i in Gvar.Book_Menu_Table.Columns)
            {
                yfilter.Items.Add(i.ColumnName);
            }
        }

        private void searchfilter(object sender, EventArgs e)
        {
            if(database.query("select * from bookstable where "+yfilter.Text+" like '%" + emBox.Text + "%' ") && yfilter.Text.Length != 0 && emBox.Text.Length != 0) 
            { Gvar.Book_Menu_Table = database.returnTable; }
            else
            {
                database.query("select * from bookstable");
                Gvar.Book_Menu_Table = database.returnTable;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                if (row != null)
                {
                    Gvar.BookManager_SelectedID = row.Cells["referencenumber"].Value.ToString();

                }
            }
        }

        private void process_Tick(object sender, EventArgs e)
        {


            dataGridView1.DataSource = Gvar.Book_Menu_Table;
        }

        private void btn_deleteBook_Click(object sender, EventArgs e)
        {

        }
    }
}
