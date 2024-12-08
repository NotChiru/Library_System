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

        }

        private void onready(object sender, EventArgs e)
        {
            database.query("select * from bookstable");
            Gvar.Book_Menu_Table= database.returnTable;
            
        }

        private void _process_Tick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Gvar.Book_Menu_Table;
        }
    }
}
