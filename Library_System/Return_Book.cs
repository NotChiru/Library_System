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
            string return_message = "Do you want to return this book? \nTitle: JHEBI'S ADVENTURE WITH HIS UMBRELLA";
            DialogResult result = MessageBox.Show(return_message, "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                
            }
            else if (result == DialogResult.No)
            {
                
            }
        }
    }
}
