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
            this.cbxMovie = new System.Windows.Forms.ComboBox();
            this.gbxAbout = new System.Windows.Forms.GroupBox();
            this.rtbxMovie = new System.Windows.Forms.RichTextBox();
            this.lblSeat = new System.Windows.Forms.Label();
            this.numSeats = new System.Windows.Forms.NumericUpDown();
            this.gbxDateTime = new System.Windows.Forms.GroupBox();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbxTime = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.gbxTicket = new System.Windows.Forms.GroupBox();
            this.rtbxOut = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.gbxUser = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxMovie.SuspendLayout();
            this.gbxAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).BeginInit();
            this.gbxDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxTicket.SuspendLayout();
            this.gbxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMovie
            // 
            this.gbxMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbxMovie.Controls.Add(this.cbxMovie);
            this.gbxMovie.Controls.Add(this.gbxAbout);
            this.gbxMovie.Controls.Add(this.lblSeat);
            this.gbxMovie.Controls.Add(this.numSeats);
            this.gbxMovie.Location = new System.Drawing.Point(502, 67);
            this.gbxMovie.Name = "gbxMovie";
            this.gbxMovie.Size = new System.Drawing.Size(373, 353);
            this.gbxMovie.TabIndex = 1;
            this.gbxMovie.TabStop = false;
            this.gbxMovie.Text = "Movie:";
            this.gbxMovie.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.lblSeat.Location = new System.Drawing.Point(31, 250);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(48, 17);
            this.lblSeat.TabIndex = 9;
            this.lblSeat.Text = "Seats:";
            // 
            // numSeats
            // 
            this.numSeats.Location = new System.Drawing.Point(144, 248);
            this.numSeats.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numSeats.Name = "numSeats";
            this.numSeats.Size = new System.Drawing.Size(57, 22);
            this.numSeats.TabIndex = 8;
            // 
            // gbxDateTime
            // 
            this.gbxDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbxDateTime.Controls.Add(this.lblDateAndTime);
            this.gbxDateTime.Controls.Add(this.dgvBookings);
            this.gbxDateTime.Controls.Add(this.groupBox5);
            this.gbxDateTime.Controls.Add(this.groupBox2);
            this.gbxDateTime.Location = new System.Drawing.Point(12, 67);
            this.gbxDateTime.Name = "gbxDateTime";
            this.gbxDateTime.Size = new System.Drawing.Size(493, 353);
            this.gbxDateTime.TabIndex = 3;
            this.gbxDateTime.TabStop = false;
            this.gbxDateTime.Text = "Day:";
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.Location = new System.Drawing.Point(223, 22);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(46, 17);
            this.lblDateAndTime.TabIndex = 5;
            this.lblDateAndTime.Text = "label3";
            // 
            // dgvBookings
            // 
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Location = new System.Drawing.Point(12, 47);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.RowTemplate.Height = 24;
            this.dgvBookings.Size = new System.Drawing.Size(475, 133);
            this.dgvBookings.TabIndex = 4;
            this.dgvBookings.SelectionChanged += new System.EventHandler(this.dgvBookings_SelectionChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox5.Controls.Add(this.cbxTime);
            this.groupBox5.Location = new System.Drawing.Point(239, 186);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(245, 95);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Time:";
            // 
            // cbxTime
            // 
            this.cbxTime.FormattingEnabled = true;
            this.cbxTime.Items.AddRange(new object[] {
            "14:00 - 16:30",
            "17:00 - 19:30",
            "20:00 - 22:30"});
            this.cbxTime.Location = new System.Drawing.Point(22, 47);
            this.cbxTime.Name = "cbxTime";
            this.cbxTime.Size = new System.Drawing.Size(205, 24);
            this.cbxTime.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.txtdate);
            this.groupBox2.Location = new System.Drawing.Point(9, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 95);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date:";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(7, 47);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(187, 22);
            this.txtdate.TabIndex = 0;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(726, 426);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(128, 58);
            this.btnBook.TabIndex = 4;
            this.btnBook.Text = "Book Movie";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // gbxTicket
            // 
            this.gbxTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            this.btnClose.Location = new System.Drawing.Point(726, 563);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 68);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Back to welcome page";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(726, 490);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(128, 67);
            this.btnreset.TabIndex = 7;
            this.btnreset.Text = "Reset Page";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbxUser
            // 
            this.gbxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(884, 678);
            this.Controls.Add(this.gbxUser);
            this.Controls.Add(this.btnreset);
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
            this.gbxAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).EndInit();
            this.gbxDateTime.ResumeLayout(false);
            this.gbxDateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxTicket.ResumeLayout(false);
            this.gbxUser.ResumeLayout(false);
            this.gbxUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxMovie;
        private System.Windows.Forms.GroupBox gbxDateTime;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.GroupBox gbxTicket;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.RichTextBox rtbxMovie;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.NumericUpDown numSeats;
        private System.Windows.Forms.ComboBox cbxMovie;
        private System.Windows.Forms.GroupBox gbxAbout;
        private System.Windows.Forms.RichTextBox rtbxOut;
        private System.Windows.Forms.GroupBox gbxUser;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbxTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label lblDateAndTime;
    }
}