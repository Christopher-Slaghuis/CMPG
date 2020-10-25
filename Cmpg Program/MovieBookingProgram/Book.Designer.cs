namespace MovieBookingProgram
{
    partial class Book
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
            this.gbxMovie = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRestriction = new System.Windows.Forms.Label();
            this.cbxMovie = new System.Windows.Forms.ComboBox();
            this.gbxAbout = new System.Windows.Forms.GroupBox();
            this.rtbxMovie = new System.Windows.Forms.RichTextBox();
            this.lblSeat = new System.Windows.Forms.Label();
            this.numSeats = new System.Windows.Forms.NumericUpDown();
            this.gbxGenre = new System.Windows.Forms.GroupBox();
            this.cbxGenre = new System.Windows.Forms.ComboBox();
            this.gbxDateTime = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbxEvent = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSpecialPrice = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtbxSpecial = new System.Windows.Forms.RichTextBox();
            this.cbxSpecial = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.gbxTicket = new System.Windows.Forms.GroupBox();
            this.rtbxOut = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxUser = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxMovie.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).BeginInit();
            this.gbxGenre.SuspendLayout();
            this.gbxDateTime.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbxEvent.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMovie
            // 
            this.gbxMovie.Controls.Add(this.groupBox1);
            this.gbxMovie.Controls.Add(this.cbxMovie);
            this.gbxMovie.Controls.Add(this.gbxAbout);
            this.gbxMovie.Controls.Add(this.lblSeat);
            this.gbxMovie.Controls.Add(this.numSeats);
            this.gbxMovie.Controls.Add(this.gbxGenre);
            this.gbxMovie.Location = new System.Drawing.Point(511, 67);
            this.gbxMovie.Name = "gbxMovie";
            this.gbxMovie.Size = new System.Drawing.Size(364, 353);
            this.gbxMovie.TabIndex = 1;
            this.gbxMovie.TabStop = false;
            this.gbxMovie.Text = "Movie:";
            this.gbxMovie.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRestriction);
            this.groupBox1.Location = new System.Drawing.Point(124, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 60);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restrictions:";
            // 
            // lblRestriction
            // 
            this.lblRestriction.AutoSize = true;
            this.lblRestriction.Location = new System.Drawing.Point(6, 32);
            this.lblRestriction.Name = "lblRestriction";
            this.lblRestriction.Size = new System.Drawing.Size(120, 17);
            this.lblRestriction.TabIndex = 3;
            this.lblRestriction.Text = "#### - Restriction";
            // 
            // cbxMovie
            // 
            this.cbxMovie.FormattingEnabled = true;
            this.cbxMovie.Location = new System.Drawing.Point(9, 35);
            this.cbxMovie.Name = "cbxMovie";
            this.cbxMovie.Size = new System.Drawing.Size(343, 24);
            this.cbxMovie.TabIndex = 11;
            this.cbxMovie.SelectedIndexChanged += new System.EventHandler(this.cbxMovie_SelectedIndexChanged);
            // 
            // gbxAbout
            // 
            this.gbxAbout.Controls.Add(this.rtbxMovie);
            this.gbxAbout.Location = new System.Drawing.Point(15, 65);
            this.gbxAbout.Name = "gbxAbout";
            this.gbxAbout.Size = new System.Drawing.Size(337, 141);
            this.gbxAbout.TabIndex = 10;
            this.gbxAbout.TabStop = false;
            this.gbxAbout.Text = "About:";
            // 
            // rtbxMovie
            // 
            this.rtbxMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rtbxMovie.Location = new System.Drawing.Point(6, 21);
            this.rtbxMovie.Name = "rtbxMovie";
            this.rtbxMovie.Size = new System.Drawing.Size(325, 109);
            this.rtbxMovie.TabIndex = 6;
            this.rtbxMovie.Text = "";
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Location = new System.Drawing.Point(32, 298);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(48, 17);
            this.lblSeat.TabIndex = 9;
            this.lblSeat.Text = "Seats:";
            // 
            // numSeats
            // 
            this.numSeats.Location = new System.Drawing.Point(86, 296);
            this.numSeats.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numSeats.Name = "numSeats";
            this.numSeats.Size = new System.Drawing.Size(57, 22);
            this.numSeats.TabIndex = 8;
            // 
            // gbxGenre
            // 
            this.gbxGenre.Controls.Add(this.cbxGenre);
            this.gbxGenre.Location = new System.Drawing.Point(14, 212);
            this.gbxGenre.Name = "gbxGenre";
            this.gbxGenre.Size = new System.Drawing.Size(104, 60);
            this.gbxGenre.TabIndex = 4;
            this.gbxGenre.TabStop = false;
            this.gbxGenre.Text = "Genre:";
            this.gbxGenre.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // cbxGenre
            // 
            this.cbxGenre.FormattingEnabled = true;
            this.cbxGenre.Location = new System.Drawing.Point(9, 21);
            this.cbxGenre.Name = "cbxGenre";
            this.cbxGenre.Size = new System.Drawing.Size(89, 24);
            this.cbxGenre.TabIndex = 8;
            this.cbxGenre.SelectedIndexChanged += new System.EventHandler(this.cbxGenre_SelectedIndexChanged);
            // 
            // gbxDateTime
            // 
            this.gbxDateTime.Controls.Add(this.groupBox5);
            this.gbxDateTime.Controls.Add(this.gbxEvent);
            this.gbxDateTime.Controls.Add(this.groupBox2);
            this.gbxDateTime.Location = new System.Drawing.Point(12, 67);
            this.gbxDateTime.Name = "gbxDateTime";
            this.gbxDateTime.Size = new System.Drawing.Size(493, 353);
            this.gbxDateTime.TabIndex = 3;
            this.gbxDateTime.TabStop = false;
            this.gbxDateTime.Text = "Day:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Location = new System.Drawing.Point(199, 35);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(262, 95);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Time:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "14:00 - 16:30",
            "17:00 - 19:30",
            "20:00 - 22:30"});
            this.comboBox1.Location = new System.Drawing.Point(6, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // gbxEvent
            // 
            this.gbxEvent.Controls.Add(this.groupBox4);
            this.gbxEvent.Controls.Add(this.groupBox3);
            this.gbxEvent.Controls.Add(this.cbxSpecial);
            this.gbxEvent.Location = new System.Drawing.Point(6, 28);
            this.gbxEvent.Name = "gbxEvent";
            this.gbxEvent.Size = new System.Drawing.Size(175, 304);
            this.gbxEvent.TabIndex = 3;
            this.gbxEvent.TabStop = false;
            this.gbxEvent.Text = "Special";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSpecialPrice);
            this.groupBox4.Location = new System.Drawing.Point(3, 216);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(156, 60);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Price:";
            // 
            // lblSpecialPrice
            // 
            this.lblSpecialPrice.AutoSize = true;
            this.lblSpecialPrice.Location = new System.Drawing.Point(6, 32);
            this.lblSpecialPrice.Name = "lblSpecialPrice";
            this.lblSpecialPrice.Size = new System.Drawing.Size(85, 17);
            this.lblSpecialPrice.TabIndex = 3;
            this.lblSpecialPrice.Text = "#### - Price";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtbxSpecial);
            this.groupBox3.Location = new System.Drawing.Point(7, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 141);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "About:";
            // 
            // rtbxSpecial
            // 
            this.rtbxSpecial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rtbxSpecial.Location = new System.Drawing.Point(6, 21);
            this.rtbxSpecial.Name = "rtbxSpecial";
            this.rtbxSpecial.Size = new System.Drawing.Size(150, 109);
            this.rtbxSpecial.TabIndex = 6;
            this.rtbxSpecial.Text = "";
            // 
            // cbxSpecial
            // 
            this.cbxSpecial.FormattingEnabled = true;
            this.cbxSpecial.Location = new System.Drawing.Point(7, 22);
            this.cbxSpecial.Name = "cbxSpecial";
            this.cbxSpecial.Size = new System.Drawing.Size(162, 24);
            this.cbxSpecial.TabIndex = 0;
            this.cbxSpecial.SelectedIndexChanged += new System.EventHandler(this.cbxSpecial_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(199, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 95);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "##/##/## - date";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(756, 432);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 4;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // gbxTicket
            // 
            this.gbxTicket.Controls.Add(this.rtbxOut);
            this.gbxTicket.Location = new System.Drawing.Point(12, 426);
            this.gbxTicket.Name = "gbxTicket";
            this.gbxTicket.Size = new System.Drawing.Size(691, 211);
            this.gbxTicket.TabIndex = 5;
            this.gbxTicket.TabStop = false;
            this.gbxTicket.Text = "Your Ticket:";
            // 
            // rtbxOut
            // 
            this.rtbxOut.Location = new System.Drawing.Point(6, 21);
            this.rtbxOut.Name = "rtbxOut";
            this.rtbxOut.Size = new System.Drawing.Size(679, 184);
            this.rtbxOut.TabIndex = 0;
            this.rtbxOut.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(756, 490);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(756, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(756, 519);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 118);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // gbxUser
            // 
            this.gbxUser.Controls.Add(this.btnCheck);
            this.gbxUser.Controls.Add(this.txtLastName);
            this.gbxUser.Controls.Add(this.label2);
            this.gbxUser.Controls.Add(this.txtFirstName);
            this.gbxUser.Controls.Add(this.label1);
            this.gbxUser.Location = new System.Drawing.Point(12, 11);
            this.gbxUser.Name = "gbxUser";
            this.gbxUser.Size = new System.Drawing.Size(863, 57);
            this.gbxUser.TabIndex = 9;
            this.gbxUser.TabStop = false;
            this.gbxUser.Text = "User:";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(423, 22);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 22);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(306, 22);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(92, 22);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 678);
            this.Controls.Add(this.gbxUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbxTicket);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.gbxDateTime);
            this.Controls.Add(this.gbxMovie);
            this.Name = "Book";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Book_Load);
            this.gbxMovie.ResumeLayout(false);
            this.gbxMovie.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).EndInit();
            this.gbxGenre.ResumeLayout(false);
            this.gbxDateTime.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.gbxEvent.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxTicket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxUser.ResumeLayout(false);
            this.gbxUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxMovie;
        private System.Windows.Forms.GroupBox gbxGenre;
        private System.Windows.Forms.GroupBox gbxDateTime;
        private System.Windows.Forms.GroupBox gbxEvent;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.GroupBox gbxTicket;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtbxMovie;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.NumericUpDown numSeats;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRestriction;
        private System.Windows.Forms.ComboBox cbxMovie;
        private System.Windows.Forms.GroupBox gbxAbout;
        private System.Windows.Forms.ComboBox cbxGenre;
        private System.Windows.Forms.ComboBox cbxSpecial;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblSpecialPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtbxSpecial;
        private System.Windows.Forms.RichTextBox rtbxOut;
        private System.Windows.Forms.GroupBox gbxUser;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheck;
    }
}