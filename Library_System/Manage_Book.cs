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
        AddBooks_Form addBooks_Form = new AddBooks_Form();

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            addBooks_Form.ShowDialog();
        }

        private void btn_bookDetails_Click(object sender, EventArgs e)
        {
            viewBooks_Form.ShowDialog();
        }
    }
}
