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
    public partial class Manage_Account : Form
    {
        public Manage_Account()
        {
            InitializeComponent();
        }
        AddAccount_Form addAccountForm = new AddAccount_Form();
        private void btn_addAccount_Click(object sender, EventArgs e)
        {
            addAccountForm.ShowDialog();
        }

        private void onready(object sender, EventArgs e)
        {
            database.query("select * from member");
            Gvar.Account_Manage_Table = database.returnTable;
        }

        private void _process_Tick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Gvar.Account_Manage_Table;
        }
    }
}
