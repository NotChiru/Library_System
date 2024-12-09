using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class AddAccount_Form : Form
    {
        public AddAccount_Form()
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

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btn_createAcc_Click(object sender, EventArgs e)
        {
            Regex emailAdd = new Regex(@"^\w+@[a-zA-Z_]+?.[a-zA-Z]{2,3}$");
            Regex name = new Regex(@"^[A-Z][a-zA-Z]*$");
            Regex studNo = new Regex(@"^((^\d{11}$))");

            bool validation = emailAdd.IsMatch(txt_email.Text) && name.IsMatch(txt_name.Text);// && studNo.IsMatch(txt_accNo.Text);
            
            if (true){
                String values = "'" + txt_accNo.Text + "','" + txt_name.Text + "','" + txt_email.Text + "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + pwBox.Text + "'";
                database.query("insert into member (member_id,memname,address,bday,member,password) values (" + values + ")");
            } else
            {
                MessageBox.Show("Incorrect Information Given");
            }

            database.query("select * from member");
            Gvar.Account_Manage_Table = database.returnTable;

        }

        private void btn_showpass_Click(object sender, EventArgs e)
        {
            if (pwBox.PasswordChar != '\0') { pwBox.PasswordChar = '\0'; }

            else { pwBox.PasswordChar = '*'; }
        }
    }
}
