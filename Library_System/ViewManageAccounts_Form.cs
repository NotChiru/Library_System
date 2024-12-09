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
    public partial class ViewManageAccounts_Form : Form
    {

        public ViewManageAccounts_Form()
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

        private void ViewManageAccounts_Form_Load(object sender, EventArgs e)
        {

        }

        private void onready(object sender, EventArgs e)
        {
            txt_name.ReadOnly = !Gvar.CurrentUserIsAdmin;
            txt_email.ReadOnly = !Gvar.CurrentUserIsAdmin;
            txt_bday.ReadOnly = !Gvar.CurrentUserIsAdmin;
            txt_accNo.ReadOnly = !Gvar.CurrentUserIsAdmin;
            

            savedata.Visible = Gvar.CurrentUserIsAdmin;
            savedata.Enabled = Gvar.CurrentUserIsAdmin;

            database.query("select memname from member where member_id = '"+Gvar.Accountmanager_selectedID+"'");
            txt_name.Text = database.returnSingle;

            database.query("select address from member where member_id = '" + Gvar.Accountmanager_selectedID + "'");
            txt_email.Text = database.returnSingle;

            database.query("select bday from member where member_id = '" + Gvar.Accountmanager_selectedID + "'");
            txt_bday.Text = database.returnSingle;

            database.query("select member from member where member_id = '" + Gvar.Accountmanager_selectedID + "'");
            comboBox2.Text = database.returnSingle;

            comboBox2.Enabled = Gvar.CurrentUserIsAdmin;

            
        }

        private void savedata_Click(object sender, EventArgs e)
        {
            database.query("update member " +
                "set " +
                "memname = '" +  txt_name.Text + "', " +
                "address = '" + txt_email.Text + "', " +
                "bday = '" + txt_bday.Text + "', " +
                "member = '" + comboBox2.Text + "' "+

                "where member_id = '" + Gvar.Accountmanager_selectedID + "'");

            database.query("select * from member");
            Gvar.Account_Manage_Table = database.returnTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
