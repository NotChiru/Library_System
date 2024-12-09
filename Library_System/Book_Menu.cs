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
    public partial class Book_Menu : Form
    {
        public Book_Menu()
        {
            InitializeComponent();
        }

        private void btn_bookDetails_Click_1(object sender, EventArgs e)
        {
            ViewBooks_Form viewBooks_Form = new ViewBooks_Form();
            viewBooks_Form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                if (row != null)
                {
                    Gvar.BookManager_SelectedID = row.Cells["ReferenceNumber"].Value.ToString();
                     
                }
            }
        }

        private void onready(object sender, EventArgs e)
        {
            database.query("select * from bookstable");
            Gvar.Book_Menu_Table= database.returnTable;
            
            foreach(DataColumn i in Gvar.Book_Menu_Table.Columns)
            {
                comboBox1.Items.Add(i.ColumnName);
            }
        }

        private void _process_Tick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Gvar.Book_Menu_Table;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Searchquery(object sender, EventArgs e)
        {
            if (database.query("select * from bookstable where " + comboBox1.Text + " like '%" + emBox.Text + "%' ") && comboBox1.Text.Length != 0 && emBox.Text.Length != 0)
            { Gvar.Book_Menu_Table = database.returnTable; }
            else
            {
                database.query("select * from bookstable");
                Gvar.Book_Menu_Table = database.returnTable;
            }
        }
    }
}
