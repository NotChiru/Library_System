namespace Library_System
{
    partial class ViewBooks_Form
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.borrow_labe = new System.Windows.Forms.Label();
            this.txt_dateAdded = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_refNo = new System.Windows.Forms.TextBox();
            this.txt_bookType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_borrow = new System.Windows.Forms.Button();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(-1, -26);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(908, 578);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Location = new System.Drawing.Point(-15, 56);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 67);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(332, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Details";
            this.label1.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.borrow_labe);
            this.panel1.Controls.Add(this.txt_dateAdded);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_fee);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_refNo);
            this.panel1.Controls.Add(this.txt_bookType);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_borrow);
            this.panel1.Controls.Add(this.txt_category);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txt_author);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txt_title);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-3, 110);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 432);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // borrow_labe
            // 
            this.borrow_labe.AutoSize = true;
            this.borrow_labe.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow_labe.ForeColor = System.Drawing.Color.Red;
            this.borrow_labe.Location = new System.Drawing.Point(266, 394);
            this.borrow_labe.Name = "borrow_labe";
            this.borrow_labe.Size = new System.Drawing.Size(452, 33);
            this.borrow_labe.TabIndex = 51;
            this.borrow_labe.Text = "Book is Currently Being Borrowed";
            this.borrow_labe.Visible = false;
            // 
            // txt_dateAdded
            // 
            this.txt_dateAdded.Enabled = false;
            this.txt_dateAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_dateAdded.Location = new System.Drawing.Point(313, 234);
            this.txt_dateAdded.Name = "txt_dateAdded";
            this.txt_dateAdded.Size = new System.Drawing.Size(212, 24);
            this.txt_dateAdded.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(233, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Borrowing Fee: ₱";
            // 
            // txt_fee
            // 
            this.txt_fee.Enabled = false;
            this.txt_fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_fee.Location = new System.Drawing.Point(359, 365);
            this.txt_fee.Name = "txt_fee";
            this.txt_fee.Size = new System.Drawing.Size(64, 24);
            this.txt_fee.TabIndex = 44;
            this.txt_fee.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(406, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 22);
            this.label7.TabIndex = 43;
            this.label7.Text = "Book Borrowing";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(226, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Copyright:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(246, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Reference No.:";
            // 
            // txt_refNo
            // 
            this.txt_refNo.Enabled = false;
            this.txt_refNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_refNo.Location = new System.Drawing.Point(249, 297);
            this.txt_refNo.Name = "txt_refNo";
            this.txt_refNo.Size = new System.Drawing.Size(276, 24);
            this.txt_refNo.TabIndex = 40;
            // 
            // txt_bookType
            // 
            this.txt_bookType.Enabled = false;
            this.txt_bookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_bookType.Location = new System.Drawing.Point(313, 188);
            this.txt_bookType.Name = "txt_bookType";
            this.txt_bookType.Size = new System.Drawing.Size(212, 24);
            this.txt_bookType.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(222, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Book Type:";
            // 
            // btn_borrow
            // 
            this.btn_borrow.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrow.ForeColor = System.Drawing.Color.Black;
            this.btn_borrow.Location = new System.Drawing.Point(572, 361);
            this.btn_borrow.Name = "btn_borrow";
            this.btn_borrow.Size = new System.Drawing.Size(127, 30);
            this.btn_borrow.TabIndex = 33;
            this.btn_borrow.Text = "BORROW BOOK";
            this.btn_borrow.UseVisualStyleBackColor = true;
            this.btn_borrow.Click += new System.EventHandler(this.btn_borrow_Click);
            // 
            // txt_category
            // 
            this.txt_category.Enabled = false;
            this.txt_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_category.Location = new System.Drawing.Point(313, 142);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(212, 24);
            this.txt_category.TabIndex = 32;
            this.txt_category.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(233, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 17);
            this.label16.TabIndex = 31;
            this.label16.Text = "Category:";
            // 
            // txt_author
            // 
            this.txt_author.Enabled = false;
            this.txt_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_author.Location = new System.Drawing.Point(313, 100);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(405, 24);
            this.txt_author.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(246, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Author:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(222, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Book Title:";
            // 
            // txt_title
            // 
            this.txt_title.Enabled = false;
            this.txt_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_title.Location = new System.Drawing.Point(313, 55);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(405, 24);
            this.txt_title.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(200, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(558, 31);
            this.label2.TabIndex = 34;
            this.label2.Text = "__________________________________";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(191, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(558, 31);
            this.label3.TabIndex = 35;
            this.label3.Text = "__________________________________";
            // 
            // ViewBooks_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 552);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewBooks_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBooks_Form";
            this.Load += new System.EventHandler(this.ViewBooks_Form_Load);
            this.Shown += new System.EventHandler(this.onready);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_borrow;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_bookType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_refNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_fee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_dateAdded;
        private System.Windows.Forms.Label borrow_labe;
    }
}