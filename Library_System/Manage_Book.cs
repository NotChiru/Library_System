﻿using System;
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

        private void onready(object sender, EventArgs e)
        {
            database.query("select * from bookstable");
            dataGridView1.DataSource = database.returnTable;
        }

        private void searchfilter(object sender, EventArgs e)
        {
            if(database.query("select * from bookstable where "+yfilter.Text+" = '" + emBox.Text + "'") && yfilter.Text.Length != 0 && emBox.Text.Length != 0) 
            { dataGridView1.DataSource = database.returnTable; }
            else
            {
                database.query("select * from bookstable");
                dataGridView1.DataSource = database.returnTable;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
