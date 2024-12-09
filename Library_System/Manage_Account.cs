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
        
        AddAccount_Form addAccountForm = new AddAccount_Form();
        ViewManageAccounts_Form viewmanageaccunts = new ViewManageAccounts_Form();

        public Manage_Account()
        {
            InitializeComponent();
        }
        
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

        private void btn_accountDetails_Click(object sender, EventArgs e)
        {
            if(Gvar.Accountmanager_selectedID != null)
            {
                viewmanageaccunts.ShowDialog();
            } else { MessageBox.Show("No Accounts Selected"); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                if (row != null)
                {
                    selectedID = row.Cells["member_id"].Value.ToString();

                }
            }

        }
    }
}
