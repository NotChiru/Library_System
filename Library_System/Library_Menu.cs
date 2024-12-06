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
    public partial class Library_Menu : Form
    {
        public Library_Menu()
        {
            InitializeComponent();
        }
        Book_Menu books_Menu = new Book_Menu();
        Return_Book return_Book = new Return_Book();

        void hide_all()
        {
            books_Menu.Hide();
            return_Book.Hide();
        }
        private void Library_Menu_Load(object sender, EventArgs e)
        {

        }

        private void menu_books_Click(object sender, EventArgs e)
        {
            hide_all();
            books_Menu.MdiParent = this;
            books_Menu.Show();
        }

        private void menu_library_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void Account_Details_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void menu_return_Click(object sender, EventArgs e)
        {
            hide_all();
            return_Book.MdiParent = this;
            return_Book.Show();
        }
    }
}