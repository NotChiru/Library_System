namespace Library_System
{
    partial class Library_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.Account_Details = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_return = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_books = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_library = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Moccasin;
            this.panel4.Controls.Add(this.Account_Details);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 552);
            this.panel4.TabIndex = 15;
            // 
            // Account_Details
            // 
            this.Account_Details.AutoSize = true;
            this.Account_Details.BackColor = System.Drawing.Color.LightGray;
            this.Account_Details.Location = new System.Drawing.Point(91, 50);
            this.Account_Details.Name = "Account_Details";
            this.Account_Details.Size = new System.Drawing.Size(73, 13);
            this.Account_Details.TabIndex = 22;
            this.Account_Details.TabStop = true;
            this.Account_Details.Text = "View Account";
            this.Account_Details.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Account_Details_LinkClicked_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightGray;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(88, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 21);
            this.label12.TabIndex = 16;
            this.label12.Text = "Archille";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem7,
            this.toolStripMenuItem3,
            this.logout,
            this.toolStripMenuItem6,
            this.menu_return,
            this.toolStripMenuItem1,
            this.menu_books,
            this.toolStripMenuItem4,
            this.menu_library});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(243, 554);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(240, 28);
            this.toolStripMenuItem5.Text = "                                            ";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem6.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.toolStripMenuItem6.Enabled = false;
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(240, 28);
            this.toolStripMenuItem6.Text = "                                            ";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(240, 28);
            this.toolStripMenuItem1.Text = "                               ";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.toolStripMenuItem4.Enabled = false;
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(240, 28);
            this.toolStripMenuItem4.Text = "                               ";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.toolStripMenuItem3.Enabled = false;
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(240, 28);
            this.toolStripMenuItem3.Text = "                                            ";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem7.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.toolStripMenuItem7.Enabled = false;
            this.toolStripMenuItem7.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(240, 28);
            this.toolStripMenuItem7.Text = "                                            ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.BackgroundImage = global::Library_System.Properties.Resources.blackBorder_transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // logout
            // 
            this.logout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logout.BackColor = System.Drawing.Color.DimGray;
            this.logout.BackgroundImage = global::Library_System.Properties.Resources.black_151767_1280;
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Snow;
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(240, 35);
            this.logout.Text = "LOG OUT";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // menu_return
            // 
            this.menu_return.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menu_return.BackColor = System.Drawing.Color.Gray;
            this.menu_return.BackgroundImage = global::Library_System.Properties.Resources.black_151767_1280;
            this.menu_return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_return.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_return.ForeColor = System.Drawing.Color.Snow;
            this.menu_return.Name = "menu_return";
            this.menu_return.Size = new System.Drawing.Size(240, 35);
            this.menu_return.Text = "Return Book";
            this.menu_return.Click += new System.EventHandler(this.menu_return_Click);
            // 
            // menu_books
            // 
            this.menu_books.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menu_books.BackColor = System.Drawing.Color.Gray;
            this.menu_books.BackgroundImage = global::Library_System.Properties.Resources.black_151767_1280;
            this.menu_books.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_books.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_books.ForeColor = System.Drawing.Color.Snow;
            this.menu_books.Name = "menu_books";
            this.menu_books.Size = new System.Drawing.Size(240, 35);
            this.menu_books.Text = "View Books";
            this.menu_books.Click += new System.EventHandler(this.menu_books_Click);
            // 
            // menu_library
            // 
            this.menu_library.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menu_library.BackColor = System.Drawing.Color.Gray;
            this.menu_library.BackgroundImage = global::Library_System.Properties.Resources.black_151767_1280;
            this.menu_library.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_library.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_library.ForeColor = System.Drawing.Color.Snow;
            this.menu_library.ImageTransparentColor = System.Drawing.Color.White;
            this.menu_library.Name = "menu_library";
            this.menu_library.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu_library.Size = new System.Drawing.Size(240, 35);
            this.menu_library.Text = "Library Menu";
            this.menu_library.Click += new System.EventHandler(this.menu_library_Click);
            // 
            // Library_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1155, 552);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Library_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Menu";
            this.Load += new System.EventHandler(this.Library_Menu_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem menu_return;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu_books;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menu_library;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.LinkLabel Account_Details;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}