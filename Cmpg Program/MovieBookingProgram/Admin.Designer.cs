namespace MovieBookingProgram
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            this.TclAdmin = new System.Windows.Forms.TabControl();
            this.TbHome = new System.Windows.Forms.TabPage();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.TbClients = new System.Windows.Forms.TabPage();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.TxtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.DGVClients = new System.Windows.Forms.DataGridView();
            this.LblClients = new System.Windows.Forms.Label();
            this.TbMovies = new System.Windows.Forms.TabPage();
            this.DGVMovies = new System.Windows.Forms.DataGridView();
            this.BtnDoneMovie = new System.Windows.Forms.Button();
            this.BtnEditMovie = new System.Windows.Forms.Button();
            this.BtnAddMovie = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxGenre = new System.Windows.Forms.ComboBox();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTheaterDataSet = new MovieBookingProgram.DBTheaterDataSet();
            this.TxtLanguage = new System.Windows.Forms.TextBox();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.TxtLength = new System.Windows.Forms.TextBox();
            this.TxtMovieName = new System.Windows.Forms.TextBox();
            this.lblManageMovie = new System.Windows.Forms.Label();
            this.TbGenre = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDoneGenre = new System.Windows.Forms.Button();
            this.BtnAddGenre = new System.Windows.Forms.Button();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.DGVGenres = new System.Windows.Forms.DataGridView();
            this.TbScedule = new System.Windows.Forms.TabPage();
            this.btnDoneSchedule = new System.Windows.Forms.Button();
            this.BtnDeleteSchedule = new System.Windows.Forms.Button();
            this.BtnEditSchedule = new System.Windows.Forms.Button();
            this.DGVSchedule = new System.Windows.Forms.DataGridView();
            this.CBXTime = new System.Windows.Forms.ComboBox();
            this.BtnAddSchedule = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DtStart = new System.Windows.Forms.DateTimePicker();
            this.CbxMovie = new System.Windows.Forms.ComboBox();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTheaterDataSet1 = new MovieBookingProgram.DBTheaterDataSet1();
            this.CbxCinema = new System.Windows.Forms.ComboBox();
            this.cinemasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTheaterDataSet2 = new MovieBookingProgram.DBTheaterDataSet2();
            this.label8 = new System.Windows.Forms.Label();
            this.TbBookings = new System.Windows.Forms.TabPage();
            this.BtnFilterBooking = new System.Windows.Forms.Button();
            this.BtnDoneBookings = new System.Windows.Forms.Button();
            this.BtnDeleteBooking = new System.Windows.Forms.Button();
            this.BtnEditBooking = new System.Windows.Forms.Button();
            this.LblSelectMovie = new System.Windows.Forms.Label();
            this.DGVBookings = new System.Windows.Forms.DataGridView();
            this.lblManageBooking = new System.Windows.Forms.Label();
            this.TbUser = new System.Windows.Forms.TabPage();
            this.DGVUsers = new System.Windows.Forms.DataGridView();
            this.BtnUserDone = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.btnUserEdit = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LblReports = new System.Windows.Forms.Label();
            this.TBReports = new System.Windows.Forms.TabPage();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnClients = new System.Windows.Forms.Button();
            this.BtnMovies = new System.Windows.Forms.Button();
            this.BtnGenres = new System.Windows.Forms.Button();
            this.BtnScedule = new System.Windows.Forms.Button();
            this.BtnBookings = new System.Windows.Forms.Button();
            this.BtnUser = new System.Windows.Forms.Button();
            this.genresTableAdapter = new MovieBookingProgram.DBTheaterDataSetTableAdapters.GenresTableAdapter();
            this.moviesTableAdapter = new MovieBookingProgram.DBTheaterDataSet1TableAdapters.MoviesTableAdapter();
            this.btnReports = new System.Windows.Forms.Button();
            this.cinemasTableAdapter = new MovieBookingProgram.DBTheaterDataSet2TableAdapters.CinemasTableAdapter();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbxName = new System.Windows.Forms.ComboBox();
            this.cbxMovView = new System.Windows.Forms.ComboBox();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dBTheaterDataSet3 = new MovieBookingProgram.DBTheaterDataSet3();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new MovieBookingProgram.DBTheaterDataSet3TableAdapters.ClientsTableAdapter();
            this.label18 = new System.Windows.Forms.Label();
            this.CBXSurname = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbxMovieViews = new System.Windows.Forms.ComboBox();
            this.lblMovieViews = new System.Windows.Forms.Label();
            this.lbxReport = new System.Windows.Forms.ListBox();
            this.btnView = new System.Windows.Forms.Button();
            this.TclAdmin.SuspendLayout();
            this.TbHome.SuspendLayout();
            this.TbClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClients)).BeginInit();
            this.TbMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTheaterDataSet)).BeginInit();
            this.TbGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGenres)).BeginInit();
            this.TbScedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTheaterDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTheaterDataSet2)).BeginInit();
            this.TbBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBookings)).BeginInit();
            this.TbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
            this.TBReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBTheaterDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TclAdmin
            // 
            this.TclAdmin.Controls.Add(this.TbHome);
            this.TclAdmin.Controls.Add(this.TbClients);
            this.TclAdmin.Controls.Add(this.TbMovies);
            this.TclAdmin.Controls.Add(this.TbGenre);
            this.TclAdmin.Controls.Add(this.TbScedule);
            this.TclAdmin.Controls.Add(this.TbBookings);
            this.TclAdmin.Controls.Add(this.TbUser);
            this.TclAdmin.Controls.Add(this.TBReports);
            this.TclAdmin.Location = new System.Drawing.Point(231, 0);
            this.TclAdmin.Name = "TclAdmin";
            this.TclAdmin.SelectedIndex = 0;
            this.TclAdmin.Size = new System.Drawing.Size(716, 518);
            this.TclAdmin.TabIndex = 0;
            this.TclAdmin.SelectedIndexChanged += new System.EventHandler(this.TclAdmin_SelectedIndexChanged);
            // 
            // TbHome
            // 
            this.TbHome.Controls.Add(this.lblDescription);
            this.TbHome.Controls.Add(this.lblHome);
            this.TbHome.Location = new System.Drawing.Point(4, 25);
            this.TbHome.Name = "TbHome";
            this.TbHome.Padding = new System.Windows.Forms.Padding(3);
            this.TbHome.Size = new System.Drawing.Size(708, 489);
            this.TbHome.TabIndex = 0;
            this.TbHome.Text = "Home";
            this.TbHome.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(56, 101);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(603, 183);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Welcome to the admin Side of the program. To begin please select a category from " +
    "the list on the left to begin.";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(313, 21);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(82, 17);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home Page";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // TbClients
            // 
            this.TbClients.Controls.Add(this.btnDone);
            this.TbClients.Controls.Add(this.btnEdit);
            this.TbClients.Controls.Add(this.BtnAdd);
            this.TbClients.Controls.Add(this.lblLastName);
            this.TbClients.Controls.Add(this.LblFirstName);
            this.TbClients.Controls.Add(this.TxtLastname);
            this.TbClients.Controls.Add(this.txtFirstName);
            this.TbClients.Controls.Add(this.DGVClients);
            this.TbClients.Controls.Add(this.LblClients);
            this.TbClients.Location = new System.Drawing.Point(4, 25);
            this.TbClients.Name = "TbClients";
            this.TbClients.Padding = new System.Windows.Forms.Padding(3);
            this.TbClients.Size = new System.Drawing.Size(708, 489);
            this.TbClients.TabIndex = 1;
            this.TbClients.Text = "Manage Clients";
            this.TbClients.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(428, 384);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(97, 30);
            this.btnDone.TabIndex = 10;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(428, 349);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(189, 29);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit Client";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(428, 319);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(189, 23);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Add A New Client";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(18, 355);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(18, 326);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(76, 17);
            this.LblFirstName.TabIndex = 5;
            this.LblFirstName.Text = "First Name";
            // 
            // TxtLastname
            // 
            this.TxtLastname.Location = new System.Drawing.Point(120, 355);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(178, 22);
            this.TxtLastname.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 326);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(178, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // DGVClients
            // 
            this.DGVClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClients.Location = new System.Drawing.Point(21, 44);
            this.DGVClients.Name = "DGVClients";
            this.DGVClients.RowTemplate.Height = 24;
            this.DGVClients.Size = new System.Drawing.Size(663, 238);
            this.DGVClients.TabIndex = 1;
            this.DGVClients.SelectionChanged += new System.EventHandler(this.DGVClients_SelectionChanged);
            // 
            // LblClients
            // 
            this.LblClients.AutoSize = true;
            this.LblClients.Location = new System.Drawing.Point(311, 11);
            this.LblClients.Name = "LblClients";
            this.LblClients.Size = new System.Drawing.Size(105, 17);
            this.LblClients.TabIndex = 0;
            this.LblClients.Text = "Manage Clients";
            // 
            // TbMovies
            // 
            this.TbMovies.Controls.Add(this.DGVMovies);
            this.TbMovies.Controls.Add(this.BtnDoneMovie);
            this.TbMovies.Controls.Add(this.BtnEditMovie);
            this.TbMovies.Controls.Add(this.BtnAddMovie);
            this.TbMovies.Controls.Add(this.label7);
            this.TbMovies.Controls.Add(this.label6);
            this.TbMovies.Controls.Add(this.label5);
            this.TbMovies.Controls.Add(this.label4);
            this.TbMovies.Controls.Add(this.label3);
            this.TbMovies.Controls.Add(this.label2);
            this.TbMovies.Controls.Add(this.CbxGenre);
            this.TbMovies.Controls.Add(this.TxtLanguage);
            this.TbMovies.Controls.Add(this.TxtYear);
            this.TbMovies.Controls.Add(this.TxtAge);
            this.TbMovies.Controls.Add(this.TxtLength);
            this.TbMovies.Controls.Add(this.TxtMovieName);
            this.TbMovies.Controls.Add(this.lblManageMovie);
            this.TbMovies.Location = new System.Drawing.Point(4, 25);
            this.TbMovies.Name = "TbMovies";
            this.TbMovies.Padding = new System.Windows.Forms.Padding(3);
            this.TbMovies.Size = new System.Drawing.Size(708, 489);
            this.TbMovies.TabIndex = 2;
            this.TbMovies.Text = "Manage Movies";
            this.TbMovies.UseVisualStyleBackColor = true;
            // 
            // DGVMovies
            // 
            this.DGVMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMovies.Location = new System.Drawing.Point(10, 44);
            this.DGVMovies.Name = "DGVMovies";
            this.DGVMovies.RowTemplate.Height = 24;
            this.DGVMovies.Size = new System.Drawing.Size(689, 216);
            this.DGVMovies.TabIndex = 16;
            this.DGVMovies.SelectionChanged += new System.EventHandler(this.DGVMovies_SelectionChanged);
            // 
            // BtnDoneMovie
            // 
            this.BtnDoneMovie.Location = new System.Drawing.Point(420, 388);
            this.BtnDoneMovie.Name = "BtnDoneMovie";
            this.BtnDoneMovie.Size = new System.Drawing.Size(120, 30);
            this.BtnDoneMovie.TabIndex = 15;
            this.BtnDoneMovie.Text = "Done";
            this.BtnDoneMovie.UseVisualStyleBackColor = true;
            this.BtnDoneMovie.Click += new System.EventHandler(this.BtnDoneMovie_Click);
            // 
            // BtnEditMovie
            // 
            this.BtnEditMovie.Location = new System.Drawing.Point(382, 353);
            this.BtnEditMovie.Name = "BtnEditMovie";
            this.BtnEditMovie.Size = new System.Drawing.Size(189, 29);
            this.BtnEditMovie.TabIndex = 14;
            this.BtnEditMovie.Text = "Edit Movie";
            this.BtnEditMovie.UseVisualStyleBackColor = true;
            this.BtnEditMovie.Click += new System.EventHandler(this.BtnEditMovie_Click);
            // 
            // BtnAddMovie
            // 
            this.BtnAddMovie.Location = new System.Drawing.Point(382, 317);
            this.BtnAddMovie.Name = "BtnAddMovie";
            this.BtnAddMovie.Size = new System.Drawing.Size(189, 29);
            this.BtnAddMovie.TabIndex = 13;
            this.BtnAddMovie.Text = "Add A New Movie";
            this.BtnAddMovie.UseVisualStyleBackColor = true;
            this.BtnAddMovie.Click += new System.EventHandler(this.BtnAddMovie_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Language";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Age Restriction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Movie Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Genre";
            // 
            // CbxGenre
            // 
            this.CbxGenre.DataSource = this.genresBindingSource;
            this.CbxGenre.DisplayMember = "Description";
            this.CbxGenre.FormattingEnabled = true;
            this.CbxGenre.Location = new System.Drawing.Point(119, 292);
            this.CbxGenre.Name = "CbxGenre";
            this.CbxGenre.Size = new System.Drawing.Size(100, 24);
            this.CbxGenre.TabIndex = 6;
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this.dBTheaterDataSet;
            // 
            // dBTheaterDataSet
            // 
            this.dBTheaterDataSet.DataSetName = "DBTheaterDataSet";
            this.dBTheaterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtLanguage
            // 
            this.TxtLanguage.Location = new System.Drawing.Point(119, 435);
            this.TxtLanguage.Name = "TxtLanguage";
            this.TxtLanguage.Size = new System.Drawing.Size(100, 22);
            this.TxtLanguage.TabIndex = 5;
            // 
            // TxtYear
            // 
            this.TxtYear.Location = new System.Drawing.Point(119, 407);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(100, 22);
            this.TxtYear.TabIndex = 4;
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(119, 379);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(100, 22);
            this.TxtAge.TabIndex = 3;
            // 
            // TxtLength
            // 
            this.TxtLength.Location = new System.Drawing.Point(119, 351);
            this.TxtLength.Name = "TxtLength";
            this.TxtLength.Size = new System.Drawing.Size(100, 22);
            this.TxtLength.TabIndex = 2;
            // 
            // TxtMovieName
            // 
            this.TxtMovieName.Location = new System.Drawing.Point(119, 323);
            this.TxtMovieName.Name = "TxtMovieName";
            this.TxtMovieName.Size = new System.Drawing.Size(100, 22);
            this.TxtMovieName.TabIndex = 1;
            // 
            // lblManageMovie
            // 
            this.lblManageMovie.AutoSize = true;
            this.lblManageMovie.Location = new System.Drawing.Point(295, 11);
            this.lblManageMovie.Name = "lblManageMovie";
            this.lblManageMovie.Size = new System.Drawing.Size(107, 17);
            this.lblManageMovie.TabIndex = 0;
            this.lblManageMovie.Text = "Manage Movies";
            // 
            // TbGenre
            // 
            this.TbGenre.Controls.Add(this.label1);
            this.TbGenre.Controls.Add(this.btnDoneGenre);
            this.TbGenre.Controls.Add(this.BtnAddGenre);
            this.TbGenre.Controls.Add(this.txtGenre);
            this.TbGenre.Controls.Add(this.DGVGenres);
            this.TbGenre.Location = new System.Drawing.Point(4, 25);
            this.TbGenre.Name = "TbGenre";
            this.TbGenre.Padding = new System.Windows.Forms.Padding(3);
            this.TbGenre.Size = new System.Drawing.Size(708, 489);
            this.TbGenre.TabIndex = 3;
            this.TbGenre.Text = "Manage Genres";
            this.TbGenre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Genre Name";
            // 
            // btnDoneGenre
            // 
            this.btnDoneGenre.Location = new System.Drawing.Point(413, 332);
            this.btnDoneGenre.Name = "btnDoneGenre";
            this.btnDoneGenre.Size = new System.Drawing.Size(75, 23);
            this.btnDoneGenre.TabIndex = 3;
            this.btnDoneGenre.Text = "Done";
            this.btnDoneGenre.UseVisualStyleBackColor = true;
            this.btnDoneGenre.Click += new System.EventHandler(this.btnDoneGenre_Click);
            // 
            // BtnAddGenre
            // 
            this.BtnAddGenre.Location = new System.Drawing.Point(355, 303);
            this.BtnAddGenre.Name = "BtnAddGenre";
            this.BtnAddGenre.Size = new System.Drawing.Size(174, 23);
            this.BtnAddGenre.TabIndex = 2;
            this.BtnAddGenre.Text = "Add a new Genre";
            this.BtnAddGenre.UseVisualStyleBackColor = true;
            this.BtnAddGenre.Click += new System.EventHandler(this.BtnAddGenre_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(129, 323);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(154, 22);
            this.txtGenre.TabIndex = 1;
            // 
            // DGVGenres
            // 
            this.DGVGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGenres.Location = new System.Drawing.Point(15, 44);
            this.DGVGenres.Name = "DGVGenres";
            this.DGVGenres.RowTemplate.Height = 24;
            this.DGVGenres.Size = new System.Drawing.Size(673, 201);
            this.DGVGenres.TabIndex = 0;
            // 
            // TbScedule
            // 
            this.TbScedule.Controls.Add(this.btnDoneSchedule);
            this.TbScedule.Controls.Add(this.BtnDeleteSchedule);
            this.TbScedule.Controls.Add(this.BtnEditSchedule);
            this.TbScedule.Controls.Add(this.DGVSchedule);
            this.TbScedule.Controls.Add(this.CBXTime);
            this.TbScedule.Controls.Add(this.BtnAddSchedule);
            this.TbScedule.Controls.Add(this.label12);
            this.TbScedule.Controls.Add(this.label11);
            this.TbScedule.Controls.Add(this.label10);
            this.TbScedule.Controls.Add(this.label9);
            this.TbScedule.Controls.Add(this.DtStart);
            this.TbScedule.Controls.Add(this.CbxMovie);
            this.TbScedule.Controls.Add(this.CbxCinema);
            this.TbScedule.Controls.Add(this.label8);
            this.TbScedule.Location = new System.Drawing.Point(4, 25);
            this.TbScedule.Name = "TbScedule";
            this.TbScedule.Padding = new System.Windows.Forms.Padding(3);
            this.TbScedule.Size = new System.Drawing.Size(708, 489);
            this.TbScedule.TabIndex = 4;
            this.TbScedule.Text = "Schedule Movie";
            this.TbScedule.UseVisualStyleBackColor = true;
            // 
            // btnDoneSchedule
            // 
            this.btnDoneSchedule.Location = new System.Drawing.Point(448, 388);
            this.btnDoneSchedule.Name = "btnDoneSchedule";
            this.btnDoneSchedule.Size = new System.Drawing.Size(148, 23);
            this.btnDoneSchedule.TabIndex = 14;
            this.btnDoneSchedule.Text = "Done";
            this.btnDoneSchedule.UseVisualStyleBackColor = true;
            this.btnDoneSchedule.Click += new System.EventHandler(this.btnDoneSchedule_Click);
            // 
            // BtnDeleteSchedule
            // 
            this.BtnDeleteSchedule.Location = new System.Drawing.Point(448, 357);
            this.BtnDeleteSchedule.Name = "BtnDeleteSchedule";
            this.BtnDeleteSchedule.Size = new System.Drawing.Size(148, 24);
            this.BtnDeleteSchedule.TabIndex = 13;
            this.BtnDeleteSchedule.Text = "Delete Schedule";
            this.BtnDeleteSchedule.UseVisualStyleBackColor = true;
            this.BtnDeleteSchedule.Click += new System.EventHandler(this.BtnDeleteSchedule_Click);
            // 
            // BtnEditSchedule
            // 
            this.BtnEditSchedule.Location = new System.Drawing.Point(448, 327);
            this.BtnEditSchedule.Name = "BtnEditSchedule";
            this.BtnEditSchedule.Size = new System.Drawing.Size(148, 24);
            this.BtnEditSchedule.TabIndex = 12;
            this.BtnEditSchedule.Text = "Edit Schedule";
            this.BtnEditSchedule.UseVisualStyleBackColor = true;
            this.BtnEditSchedule.Click += new System.EventHandler(this.BtnEditSchedule_Click);
            // 
            // DGVSchedule
            // 
            this.DGVSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSchedule.Location = new System.Drawing.Point(23, 44);
            this.DGVSchedule.Name = "DGVSchedule";
            this.DGVSchedule.RowTemplate.Height = 24;
            this.DGVSchedule.Size = new System.Drawing.Size(660, 237);
            this.DGVSchedule.TabIndex = 11;
            this.DGVSchedule.SelectionChanged += new System.EventHandler(this.DGVSchedule_SelectionChanged);
            // 
            // CBXTime
            // 
            this.CBXTime.FormattingEnabled = true;
            this.CBXTime.Location = new System.Drawing.Point(143, 395);
            this.CBXTime.Name = "CBXTime";
            this.CBXTime.Size = new System.Drawing.Size(200, 24);
            this.CBXTime.TabIndex = 10;
            // 
            // BtnAddSchedule
            // 
            this.BtnAddSchedule.Location = new System.Drawing.Point(448, 294);
            this.BtnAddSchedule.Name = "BtnAddSchedule";
            this.BtnAddSchedule.Size = new System.Drawing.Size(148, 27);
            this.BtnAddSchedule.TabIndex = 9;
            this.BtnAddSchedule.Text = "Add Schedule";
            this.BtnAddSchedule.UseVisualStyleBackColor = true;
            this.BtnAddSchedule.Click += new System.EventHandler(this.BtnSceduleMovie_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 394);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Movie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Cinema";
            // 
            // DtStart
            // 
            this.DtStart.Location = new System.Drawing.Point(143, 366);
            this.DtStart.Name = "DtStart";
            this.DtStart.Size = new System.Drawing.Size(200, 22);
            this.DtStart.TabIndex = 3;
            // 
            // CbxMovie
            // 
            this.CbxMovie.DataSource = this.moviesBindingSource;
            this.CbxMovie.DisplayMember = "Movie_Name";
            this.CbxMovie.FormattingEnabled = true;
            this.CbxMovie.Location = new System.Drawing.Point(143, 336);
            this.CbxMovie.Name = "CbxMovie";
            this.CbxMovie.Size = new System.Drawing.Size(200, 24);
            this.CbxMovie.TabIndex = 2;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.dBTheaterDataSet1;
            // 
            // dBTheaterDataSet1
            // 
            this.dBTheaterDataSet1.DataSetName = "DBTheaterDataSet1";
            this.dBTheaterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CbxCinema
            // 
            this.CbxCinema.DataSource = this.cinemasBindingSource;
            this.CbxCinema.DisplayMember = "Cin_name";
            this.CbxCinema.FormattingEnabled = true;
            this.CbxCinema.Location = new System.Drawing.Point(143, 306);
            this.CbxCinema.Name = "CbxCinema";
            this.CbxCinema.Size = new System.Drawing.Size(200, 24);
            this.CbxCinema.TabIndex = 1;
            // 
            // cinemasBindingSource
            // 
            this.cinemasBindingSource.DataMember = "Cinemas";
            this.cinemasBindingSource.DataSource = this.dBTheaterDataSet2;
            // 
            // dBTheaterDataSet2
            // 
            this.dBTheaterDataSet2.DataSetName = "DBTheaterDataSet2";
            this.dBTheaterDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Scedule Movie";
            // 
            // TbBookings
            // 
            this.TbBookings.Controls.Add(this.CBXSurname);
            this.TbBookings.Controls.Add(this.label18);
            this.TbBookings.Controls.Add(this.label17);
            this.TbBookings.Controls.Add(this.label16);
            this.TbBookings.Controls.Add(this.label15);
            this.TbBookings.Controls.Add(this.txtSeats);
            this.TbBookings.Controls.Add(this.cbxMovView);
            this.TbBookings.Controls.Add(this.cbxName);
            this.TbBookings.Controls.Add(this.txtFilter);
            this.TbBookings.Controls.Add(this.BtnFilterBooking);
            this.TbBookings.Controls.Add(this.BtnDoneBookings);
            this.TbBookings.Controls.Add(this.BtnDeleteBooking);
            this.TbBookings.Controls.Add(this.BtnEditBooking);
            this.TbBookings.Controls.Add(this.LblSelectMovie);
            this.TbBookings.Controls.Add(this.DGVBookings);
            this.TbBookings.Controls.Add(this.lblManageBooking);
            this.TbBookings.Location = new System.Drawing.Point(4, 25);
            this.TbBookings.Name = "TbBookings";
            this.TbBookings.Padding = new System.Windows.Forms.Padding(3);
            this.TbBookings.Size = new System.Drawing.Size(708, 489);
            this.TbBookings.TabIndex = 5;
            this.TbBookings.Text = "Manage Bookings";
            this.TbBookings.UseVisualStyleBackColor = true;
            // 
            // BtnFilterBooking
            // 
            this.BtnFilterBooking.Location = new System.Drawing.Point(358, 54);
            this.BtnFilterBooking.Name = "BtnFilterBooking";
            this.BtnFilterBooking.Size = new System.Drawing.Size(99, 30);
            this.BtnFilterBooking.TabIndex = 7;
            this.BtnFilterBooking.Text = "Filter Bookings";
            this.BtnFilterBooking.UseVisualStyleBackColor = true;
            this.BtnFilterBooking.Click += new System.EventHandler(this.BtnFilterBooking_Click);
            // 
            // BtnDoneBookings
            // 
            this.BtnDoneBookings.Location = new System.Drawing.Point(414, 398);
            this.BtnDoneBookings.Name = "BtnDoneBookings";
            this.BtnDoneBookings.Size = new System.Drawing.Size(75, 23);
            this.BtnDoneBookings.TabIndex = 6;
            this.BtnDoneBookings.Text = "Done";
            this.BtnDoneBookings.UseVisualStyleBackColor = true;
            this.BtnDoneBookings.Click += new System.EventHandler(this.BtnDoneBookings_Click);
            // 
            // BtnDeleteBooking
            // 
            this.BtnDeleteBooking.Location = new System.Drawing.Point(358, 369);
            this.BtnDeleteBooking.Name = "BtnDeleteBooking";
            this.BtnDeleteBooking.Size = new System.Drawing.Size(198, 23);
            this.BtnDeleteBooking.TabIndex = 5;
            this.BtnDeleteBooking.Text = "Delete Booking";
            this.BtnDeleteBooking.UseVisualStyleBackColor = true;
            this.BtnDeleteBooking.Click += new System.EventHandler(this.BtnDeleteBooking_Click);
            // 
            // BtnEditBooking
            // 
            this.BtnEditBooking.Location = new System.Drawing.Point(358, 340);
            this.BtnEditBooking.Name = "BtnEditBooking";
            this.BtnEditBooking.Size = new System.Drawing.Size(198, 23);
            this.BtnEditBooking.TabIndex = 4;
            this.BtnEditBooking.Text = "Edit Booking";
            this.BtnEditBooking.UseVisualStyleBackColor = true;
            this.BtnEditBooking.Click += new System.EventHandler(this.BtnEditBooking_Click);
            // 
            // LblSelectMovie
            // 
            this.LblSelectMovie.Location = new System.Drawing.Point(20, 46);
            this.LblSelectMovie.Name = "LblSelectMovie";
            this.LblSelectMovie.Size = new System.Drawing.Size(156, 46);
            this.LblSelectMovie.TabIndex = 3;
            this.LblSelectMovie.Text = "Please enter a booking ID to filter bookings";
            this.LblSelectMovie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVBookings
            // 
            this.DGVBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBookings.Location = new System.Drawing.Point(39, 106);
            this.DGVBookings.Name = "DGVBookings";
            this.DGVBookings.RowTemplate.Height = 24;
            this.DGVBookings.Size = new System.Drawing.Size(637, 191);
            this.DGVBookings.TabIndex = 1;
            this.DGVBookings.SelectionChanged += new System.EventHandler(this.DGVBookings_SelectionChanged);
            // 
            // lblManageBooking
            // 
            this.lblManageBooking.AutoSize = true;
            this.lblManageBooking.Location = new System.Drawing.Point(294, 11);
            this.lblManageBooking.Name = "lblManageBooking";
            this.lblManageBooking.Size = new System.Drawing.Size(121, 17);
            this.lblManageBooking.TabIndex = 0;
            this.lblManageBooking.Text = "Manage Bookings";
            // 
            // TbUser
            // 
            this.TbUser.Controls.Add(this.DGVUsers);
            this.TbUser.Controls.Add(this.BtnUserDone);
            this.TbUser.Controls.Add(this.btnUserDelete);
            this.TbUser.Controls.Add(this.btnUserAdd);
            this.TbUser.Controls.Add(this.btnUserEdit);
            this.TbUser.Controls.Add(this.txtPassword);
            this.TbUser.Controls.Add(this.txtUsername);
            this.TbUser.Controls.Add(this.label14);
            this.TbUser.Controls.Add(this.label13);
            this.TbUser.Controls.Add(this.LblReports);
            this.TbUser.Location = new System.Drawing.Point(4, 25);
            this.TbUser.Name = "TbUser";
            this.TbUser.Padding = new System.Windows.Forms.Padding(3);
            this.TbUser.Size = new System.Drawing.Size(708, 489);
            this.TbUser.TabIndex = 6;
            this.TbUser.Text = "User Control";
            this.TbUser.UseVisualStyleBackColor = true;
            // 
            // DGVUsers
            // 
            this.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsers.Location = new System.Drawing.Point(42, 44);
            this.DGVUsers.Name = "DGVUsers";
            this.DGVUsers.RowTemplate.Height = 24;
            this.DGVUsers.Size = new System.Drawing.Size(643, 186);
            this.DGVUsers.TabIndex = 9;
            this.DGVUsers.SelectionChanged += new System.EventHandler(this.DGVUsers_SelectionChanged);
            // 
            // BtnUserDone
            // 
            this.BtnUserDone.Location = new System.Drawing.Point(365, 291);
            this.BtnUserDone.Name = "BtnUserDone";
            this.BtnUserDone.Size = new System.Drawing.Size(89, 46);
            this.BtnUserDone.TabIndex = 8;
            this.BtnUserDone.Text = "Done";
            this.BtnUserDone.UseVisualStyleBackColor = true;
            this.BtnUserDone.Click += new System.EventHandler(this.BtnUserDone_Click);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Location = new System.Drawing.Point(504, 341);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(139, 36);
            this.btnUserDelete.TabIndex = 7;
            this.btnUserDelete.Text = "Delete User";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Location = new System.Drawing.Point(504, 259);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(139, 35);
            this.btnUserAdd.TabIndex = 6;
            this.btnUserAdd.Text = "Add New User";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.Location = new System.Drawing.Point(504, 300);
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Size = new System.Drawing.Size(139, 35);
            this.btnUserEdit.TabIndex = 5;
            this.btnUserEdit.Text = "Edit User";
            this.btnUserEdit.UseVisualStyleBackColor = true;
            this.btnUserEdit.Click += new System.EventHandler(this.btnUserEdit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(135, 306);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(135, 260);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Password";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Username";
            // 
            // LblReports
            // 
            this.LblReports.AutoSize = true;
            this.LblReports.Location = new System.Drawing.Point(326, 11);
            this.LblReports.Name = "LblReports";
            this.LblReports.Size = new System.Drawing.Size(87, 17);
            this.LblReports.TabIndex = 0;
            this.LblReports.Text = "User Control";
            // 
            // TBReports
            // 
            this.TBReports.Controls.Add(this.btnView);
            this.TBReports.Controls.Add(this.lbxReport);
            this.TBReports.Controls.Add(this.lblMovieViews);
            this.TBReports.Controls.Add(this.cbxMovieViews);
            this.TBReports.Controls.Add(this.label19);
            this.TBReports.Location = new System.Drawing.Point(4, 25);
            this.TBReports.Name = "TBReports";
            this.TBReports.Padding = new System.Windows.Forms.Padding(3);
            this.TBReports.Size = new System.Drawing.Size(708, 489);
            this.TBReports.TabIndex = 7;
            this.TBReports.Text = "Reports";
            this.TBReports.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(64, 452);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(83, 32);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Location = new System.Drawing.Point(53, 25);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(143, 38);
            this.BtnHome.TabIndex = 2;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnClients
            // 
            this.BtnClients.Location = new System.Drawing.Point(53, 69);
            this.BtnClients.Name = "BtnClients";
            this.BtnClients.Size = new System.Drawing.Size(143, 40);
            this.BtnClients.TabIndex = 3;
            this.BtnClients.Text = "Manage Clients";
            this.BtnClients.UseVisualStyleBackColor = true;
            this.BtnClients.Click += new System.EventHandler(this.BtnClients_Click);
            // 
            // BtnMovies
            // 
            this.BtnMovies.Location = new System.Drawing.Point(53, 115);
            this.BtnMovies.Name = "BtnMovies";
            this.BtnMovies.Size = new System.Drawing.Size(143, 39);
            this.BtnMovies.TabIndex = 4;
            this.BtnMovies.Text = "Manage Movies";
            this.BtnMovies.UseVisualStyleBackColor = true;
            this.BtnMovies.Click += new System.EventHandler(this.BtnMovies_Click);
            // 
            // BtnGenres
            // 
            this.BtnGenres.Location = new System.Drawing.Point(53, 160);
            this.BtnGenres.Name = "BtnGenres";
            this.BtnGenres.Size = new System.Drawing.Size(143, 40);
            this.BtnGenres.TabIndex = 5;
            this.BtnGenres.Text = "Manage Genres";
            this.BtnGenres.UseVisualStyleBackColor = true;
            this.BtnGenres.Click += new System.EventHandler(this.BtnGenres_Click);
            // 
            // BtnScedule
            // 
            this.BtnScedule.Location = new System.Drawing.Point(53, 206);
            this.BtnScedule.Name = "BtnScedule";
            this.BtnScedule.Size = new System.Drawing.Size(143, 38);
            this.BtnScedule.TabIndex = 6;
            this.BtnScedule.Text = "Schedule Movies";
            this.BtnScedule.UseVisualStyleBackColor = true;
            this.BtnScedule.Click += new System.EventHandler(this.BtnScedule_Click);
            // 
            // BtnBookings
            // 
            this.BtnBookings.Location = new System.Drawing.Point(53, 250);
            this.BtnBookings.Name = "BtnBookings";
            this.BtnBookings.Size = new System.Drawing.Size(143, 35);
            this.BtnBookings.TabIndex = 7;
            this.BtnBookings.Text = "Manage Bookings";
            this.BtnBookings.UseVisualStyleBackColor = true;
            this.BtnBookings.Click += new System.EventHandler(this.BtnBookings_Click);
            // 
            // BtnUser
            // 
            this.BtnUser.Location = new System.Drawing.Point(53, 291);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(143, 44);
            this.BtnUser.TabIndex = 8;
            this.BtnUser.Text = "User Control";
            this.BtnUser.UseVisualStyleBackColor = true;
            this.BtnUser.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(53, 341);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(143, 47);
            this.btnReports.TabIndex = 9;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click_1);
            // 
            // cinemasTableAdapter
            // 
            this.cinemasTableAdapter.ClearBeforeFill = true;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(182, 58);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(153, 22);
            this.txtFilter.TabIndex = 8;
            // 
            // cbxName
            // 
            this.cbxName.DataSource = this.clientsBindingSource;
            this.cbxName.DisplayMember = "First_name";
            this.cbxName.FormattingEnabled = true;
            this.cbxName.Location = new System.Drawing.Point(130, 313);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(121, 24);
            this.cbxName.TabIndex = 9;
            // 
            // cbxMovView
            // 
            this.cbxMovView.DataSource = this.moviesBindingSource;
            this.cbxMovView.DisplayMember = "Movie_Name";
            this.cbxMovView.FormattingEnabled = true;
            this.cbxMovView.Location = new System.Drawing.Point(130, 370);
            this.cbxMovView.Name = "cbxMovView";
            this.cbxMovView.Size = new System.Drawing.Size(121, 24);
            this.cbxMovView.TabIndex = 10;
            // 
            // txtSeats
            // 
            this.txtSeats.Location = new System.Drawing.Point(130, 400);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(121, 22);
            this.txtSeats.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 316);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "Client Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 369);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 17);
            this.label16.TabIndex = 13;
            this.label16.Text = "Movie";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 403);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 17);
            this.label17.TabIndex = 14;
            this.label17.Text = "Number of Seats";
            // 
            // dBTheaterDataSet3
            // 
            this.dBTheaterDataSet3.DataSetName = "DBTheaterDataSet3";
            this.dBTheaterDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.dBTheaterDataSet3;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 343);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 17);
            this.label18.TabIndex = 15;
            this.label18.Text = "Client Surname";
            // 
            // CBXSurname
            // 
            this.CBXSurname.DataSource = this.clientsBindingSource;
            this.CBXSurname.DisplayMember = "Last_Name";
            this.CBXSurname.FormattingEnabled = true;
            this.CBXSurname.Location = new System.Drawing.Point(130, 343);
            this.CBXSurname.Name = "CBXSurname";
            this.CBXSurname.Size = new System.Drawing.Size(121, 24);
            this.CBXSurname.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(338, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "Reports";
            // 
            // cbxMovieViews
            // 
            this.cbxMovieViews.DataSource = this.moviesBindingSource;
            this.cbxMovieViews.DisplayMember = "Movie_Name";
            this.cbxMovieViews.FormattingEnabled = true;
            this.cbxMovieViews.Location = new System.Drawing.Point(216, 53);
            this.cbxMovieViews.Name = "cbxMovieViews";
            this.cbxMovieViews.Size = new System.Drawing.Size(121, 24);
            this.cbxMovieViews.TabIndex = 4;
            // 
            // lblMovieViews
            // 
            this.lblMovieViews.AutoSize = true;
            this.lblMovieViews.Location = new System.Drawing.Point(22, 56);
            this.lblMovieViews.Name = "lblMovieViews";
            this.lblMovieViews.Size = new System.Drawing.Size(145, 17);
            this.lblMovieViews.TabIndex = 5;
            this.lblMovieViews.Text = "Please select a movie";
            this.lblMovieViews.Click += new System.EventHandler(this.lblMovieViews_Click);
            // 
            // lbxReport
            // 
            this.lbxReport.FormattingEnabled = true;
            this.lbxReport.ItemHeight = 16;
            this.lbxReport.Location = new System.Drawing.Point(39, 147);
            this.lbxReport.Name = "lbxReport";
            this.lbxReport.Size = new System.Drawing.Size(569, 260);
            this.lbxReport.TabIndex = 6;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(150, 105);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(116, 24);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View Report";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 515);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.BtnUser);
            this.Controls.Add(this.BtnBookings);
            this.Controls.Add(this.BtnScedule);
            this.Controls.Add(this.BtnGenres);
            this.Controls.Add(this.BtnMovies);
            this.Controls.Add(this.BtnClients);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.TclAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.TclAdmin.ResumeLayout(false);
            this.TbHome.ResumeLayout(false);
            this.TbHome.PerformLayout();
            this.TbClients.ResumeLayout(false);
            this.TbClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClients)).EndInit();
            this.TbMovies.ResumeLayout(false);
            this.TbMovies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTheaterDataSet)).EndInit();
            this.TbGenre.ResumeLayout(false);
            this.TbGenre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGenres)).EndInit();
            this.TbScedule.ResumeLayout(false);
            this.TbScedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTheaterDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTheaterDataSet2)).EndInit();
            this.TbBookings.ResumeLayout(false);
            this.TbBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBookings)).EndInit();
            this.TbUser.ResumeLayout(false);
            this.TbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
            this.TBReports.ResumeLayout(false);
            this.TBReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBTheaterDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TclAdmin;
        private System.Windows.Forms.TabPage TbHome;
        private System.Windows.Forms.TabPage TbClients;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TabPage TbMovies;
        private System.Windows.Forms.TabPage TbGenre;
        private System.Windows.Forms.TabPage TbScedule;
        private System.Windows.Forms.TabPage TbBookings;
        private System.Windows.Forms.TabPage TbUser;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnClients;
        private System.Windows.Forms.Button BtnMovies;
        private System.Windows.Forms.Button BtnGenres;
        private System.Windows.Forms.Button BtnScedule;
        private System.Windows.Forms.Button BtnBookings;
        private System.Windows.Forms.Button BtnUser;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DataGridView DGVClients;
        private System.Windows.Forms.Label LblClients;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.TextBox TxtLastname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.DataGridView DGVMovies;
        private System.Windows.Forms.Button BtnDoneMovie;
        private System.Windows.Forms.Button BtnEditMovie;
        private System.Windows.Forms.Button BtnAddMovie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxGenre;
        private System.Windows.Forms.TextBox TxtLanguage;
        private System.Windows.Forms.TextBox TxtYear;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.TextBox TxtLength;
        private System.Windows.Forms.TextBox TxtMovieName;
        private System.Windows.Forms.Label lblManageMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDoneGenre;
        private System.Windows.Forms.Button BtnAddGenre;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.DataGridView DGVGenres;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DtStart;
        private System.Windows.Forms.ComboBox CbxMovie;
        private System.Windows.Forms.ComboBox CbxCinema;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnDoneBookings;
        private System.Windows.Forms.Button BtnDeleteBooking;
        private System.Windows.Forms.Button BtnEditBooking;
        private System.Windows.Forms.Label LblSelectMovie;
        private System.Windows.Forms.DataGridView DGVBookings;
        private System.Windows.Forms.Label lblManageBooking;
        private System.Windows.Forms.Label LblReports;
        private DBTheaterDataSet dBTheaterDataSet;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private DBTheaterDataSetTableAdapters.GenresTableAdapter genresTableAdapter;
        private System.Windows.Forms.Button BtnAddSchedule;
        private DBTheaterDataSet1 dBTheaterDataSet1;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private DBTheaterDataSet1TableAdapters.MoviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.DataGridView DGVUsers;
        private System.Windows.Forms.Button BtnUserDone;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Button btnUserEdit;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage TBReports;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.ComboBox CBXTime;
        private DBTheaterDataSet2 dBTheaterDataSet2;
        private System.Windows.Forms.BindingSource cinemasBindingSource;
        private DBTheaterDataSet2TableAdapters.CinemasTableAdapter cinemasTableAdapter;
        private System.Windows.Forms.Button BtnDeleteSchedule;
        private System.Windows.Forms.Button BtnEditSchedule;
        private System.Windows.Forms.DataGridView DGVSchedule;
        private System.Windows.Forms.Button btnDoneSchedule;
        private System.Windows.Forms.Button BtnFilterBooking;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.ComboBox cbxMovView;
        private System.Windows.Forms.ComboBox cbxName;
        private DBTheaterDataSet3 dBTheaterDataSet3;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private DBTheaterDataSet3TableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.ComboBox CBXSurname;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ListBox lbxReport;
        private System.Windows.Forms.Label lblMovieViews;
        private System.Windows.Forms.ComboBox cbxMovieViews;
        private System.Windows.Forms.Label label19;
    }
}