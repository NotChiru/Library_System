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
    public partial class Book_Menu : Form
    {
        public Book_Menu()
        {
            InitializeComponent();
        }

        private void bookTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_bookDetails_Click_1(object sender, EventArgs e)
        {
            ViewBooks_Form viewBooks_Form = new ViewBooks_Form();
            viewBooks_Form.ShowDialog();
        }
    }
}
