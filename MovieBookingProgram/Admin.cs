using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieBookingProgram
{
    public partial class Admin : Form
    {
        public string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\MovieBookingProgram\DBTheater.mdf;Integrated Security=True";

        public SqlConnection conn;
        public SqlCommand cmd;
        public DataSet ds;
        public SqlDataAdapter adap;

        public bool Edit=false,Delete=false;
        public int ClientId,MovieId,ShowId,UserId,BookId;

        public Admin()
        {
            InitializeComponent();

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();         
            
            BtnHome.Visible = false;
            btnDone.Visible = false;

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmWelcome Welcome = new FrmWelcome();
            Welcome.Show();
            this.Hide();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            TclAdmin.SelectedIndex = 0;     //Chris: change tab to home
            BtnVisible();
            BtnHome.Visible = false;
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            TclAdmin.SelectedIndex = 1;     //Chris: change tabs to Clients
            BtnVisible();
            BtnClients.Visible = false;

            PopGridView("Clients");
            DGVClients.DataSource = ds;
            DGVClients.DataMember = "Data";

            txtFirstName.Enabled = false;
            TxtLastname.Enabled = false;
          
        }

        private void BtnMovies_Click(object sender, EventArgs e)
        {
            TclAdmin.SelectedIndex = 2;         //Chris: change tabs to Movies
            BtnVisible();
            BtnMovies.Visible = false;

            popCbx("SELECT Description FROM Genres", CbxGenre);

            PopGridView("Movies");
            DGVMovies.DataSource = ds;
            DGVMovies.DataMember = "Data";

            CbxGenre.Enabled = false;
            TxtMovieName.Enabled = false;
            TxtAge.Enabled = false;
            TxtLength.Enabled = false;
            TxtLanguage.Enabled = false;
            TxtYear.Enabled = false;
            BtnAddMovie.Visible = true;
            BtnDoneMovie.Visible = false;
            BtnEditMovie.Visible = true;
            txtdes.Enabled = false;
        }

        private void BtnGenres_Click(object sender, EventArgs e)
        {
            TclAdmin.SelectedIndex = 3;     //Chris: change tabs to Genres
            BtnVisible();
            BtnGenres.Visible = false;

            PopGridView("Genres");
            DGVGenres.DataSource = ds;
            DGVGenres.DataMember = "Data";

            txtGenre.Enabled = false;
            BtnAddGenre.Visible = true;
            btnDoneGenre.Visible = false;
        }

        private void BtnScedule_Click(object sender, EventArgs e)
        {
            TclAdmin.SelectedIndex = 4;         //Chris: change tabs to scedule
            BtnVisible();
            BtnScedule.Visible = false;

            CBXTime.Items.Add("14:00-16:30");
            CBXTime.Items.Add("17:00-19:30");
            CBXTime.Items.Add("20:00-22:30");

            popCbx("SELECT Cin_Name FROM Cinemas", CbxCinema);
            popCbx("SELECT Movie_Name FROM Movies", CbxMovie);

            PopGridView("ShowTimes");
            DGVSchedule.DataSource = ds;
            DGVSchedule.DataMember = "Data";

            EnabledSchedule(true);
        }

        private void BtnBookings_Click(object sender, EventArgs e)
        {
            TclAdmin.SelectedIndex = 5;         //Chris: change tabs to bookings
            BtnVisible();
            BtnBookings.Visible = false;

            popCbx("SELECT First_name FROM Clients", cbxName);
            popCbx("SELECT Last_name FROM Clients", CBXSurname);
            popCbx("SELECT Movie_Name FROM Movies", cbxMovView);

            PopGridView("Bookings");
            DGVBookings.DataSource = ds;
            DGVBookings.DataMember = "Data";

            EnableBookings(true);
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            TclAdmin.SelectedIndex = 6;     //Chris: change tabs to users
            BtnVisible();
            BtnUser.Visible = false;

            EnabledUser(true);

            PopGridView("Users");
            DGVUsers.DataSource = ds;
            DGVUsers.DataMember = "Data";
        }

        private void BtnVisible()
        {
            BtnHome.Visible = true;             //Chris:Make all menu buttons visible
            BtnClients.Visible = true;
            BtnMovies.Visible = true;
            BtnGenres.Visible = true;
            BtnScedule.Visible = true;
            BtnBookings.Visible = true;
            BtnUser.Visible = true;
            btnReports.Visible = true;
        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text!=""||TxtLastname.Text!="")
            {
                BtnAdd.Visible = true;              //Chris: Clients update and add
                btnEdit.Visible = true;
                btnDone.Visible = false;

                if (Edit == true)
                {
                    try
                    {
                        string sqlInsert = "UPDATE Clients SET First_Name = @First_Name, Last_name=@Last_Name Where Client_Id=@Client_Id";

                        conn.Open();
                        cmd = new SqlCommand(sqlInsert, conn);
                        cmd.Parameters.AddWithValue("@Client_Id", ClientId);
                        cmd.Parameters.AddWithValue("@First_Name", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@Last_Name", TxtLastname.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("New Entry Entered");
                        Edit = false;

                    }
                    catch
                    {
                        MessageBox.Show("Unable to edit data, Please try agian");
                    }
                }
                else
                {
                    try
                    {
                        conn.Open();

                        String sql_Max = "SELECT Max(Client_Id) FROM Clients";
                        cmd = new SqlCommand(sql_Max, conn);
                        int Num = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                        int ID = (int)Num + 1;

                        string sqlInsert = "INSERT INTO Clients VALUES(@ID,@First_Name,@Last_Name)";

                        cmd = new SqlCommand(sqlInsert, conn);
                        cmd.Parameters.AddWithValue("@Id", ID);
                        cmd.Parameters.AddWithValue("@First_Name", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@Last_Name", TxtLastname.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("New Entry Entered");
                    }
                    catch
                    {
                        MessageBox.Show("Unable to Create data, Please try agian");
                    }

                }

                PopGridView("Clients");
                DGVClients.DataSource = ds;
                DGVClients.DataMember = "Data";


                txtFirstName.Enabled = false;
                TxtLastname.Enabled = false;
                btnDone.Visible = false;
                BtnAdd.Visible = true;
                btnEdit.Visible = true;
                DGVClients.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please enter a Name and Surname");
            }

            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            BtnAdd.Visible = false;             //Chris: Client Edit Button
            btnEdit.Visible = false;
            btnDone.Visible = true;

            txtFirstName.Enabled = true;
            TxtLastname.Enabled = true;
            btnDone.Visible = true;
            BtnAdd.Visible = false;
            btnEdit.Visible = false;
            DGVClients.Enabled = false;
            Edit = true;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            BtnAdd.Visible = false;                     //Chris: Client Add button
            btnEdit.Visible = false;
            btnDone.Visible = true;

            txtFirstName.Enabled = true;
            TxtLastname.Enabled = true;
            btnDone.Visible = true;
            BtnAdd.Visible = false;
            btnEdit.Visible = false;
            DGVClients.Enabled = false;

            txtFirstName.Text = "";
            TxtLastname.Text = "";
            Edit = false;
        }
        private void PopGridView(string table)
        {
            conn = new SqlConnection(constr);       //Chris: Populate all data grid view
            conn.Open();
            string sql;
            adap = new SqlDataAdapter();
            ds = new DataSet();

            sql = @"SELECT * FROM "+table;
            cmd = new SqlCommand(sql, conn);


            adap.SelectCommand = cmd;
            adap.Fill(ds, "Data");           

            conn.Close();
        }

        private void DGVClients_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ClientId = Convert.ToInt16(DGVClients.CurrentRow.Cells[0].Value.ToString());
                string Name = DGVClients.CurrentRow.Cells[1].Value.ToString();
                string Surname = DGVClients.CurrentRow.Cells[2].Value.ToString();

                txtFirstName.Text = Name;
                TxtLastname.Text = Surname;
            }
            catch
            {
                MessageBox.Show("Error, Please select a valid entry");
            }
            
        }

        private void BtnAddMovie_Click(object sender, EventArgs e)
        {
            CbxGenre.Enabled = true;                    //Chris :Add movies
            TxtMovieName.Enabled = true;
            TxtAge.Enabled = true;
            TxtLength.Enabled = true;
            TxtLanguage.Enabled = true;
            TxtYear.Enabled = true;
            DGVMovies.Enabled = false;
            txtdes.Enabled = true;

            CbxGenre.SelectedIndex = -1;
            TxtMovieName.Text = "";
            TxtAge.Text = "";
            TxtLanguage.Text = "";
            TxtLength.Text = "";
            TxtYear.Text = "";

            BtnAddMovie.Visible = false;
            BtnEditMovie.Visible = false;
            BtnDoneMovie.Visible = true;

            Edit = false;
        }

        private void BtnEditMovie_Click(object sender, EventArgs e)
        {
            CbxGenre.Enabled = true;            //Chris:Edit Movies button
            TxtMovieName.Enabled = true;
            TxtAge.Enabled = true;
            TxtLength.Enabled = true;
            TxtLanguage.Enabled = true;
            TxtYear.Enabled = true;
            DGVMovies.Enabled = false;
            txtdes.Enabled = true;

            BtnAddMovie.Visible = false;
            BtnEditMovie.Visible = false;
            BtnDoneMovie.Visible = true;

            Edit = true;
        }

        private void BtnDoneMovie_Click(object sender, EventArgs e)
        {
            if (CbxGenre.SelectedIndex!=-1||TxtMovieName.Text!="" || TxtLength.Text != "" || TxtAge.Text != "" || TxtYear.Text != "" || TxtLanguage.Text != "")
            {
                CbxGenre.Enabled = false;           //Chris: Update and insert movies button
                TxtMovieName.Enabled = false;
                TxtAge.Enabled = false;
                TxtLength.Enabled = false;
                TxtLanguage.Enabled = false;
                TxtYear.Enabled = false;
                DGVMovies.Enabled = true;
                txtdes.Enabled = false;

                BtnAddMovie.Visible = true;
                BtnEditMovie.Visible = true;
                BtnDoneMovie.Visible = false;

                if (Edit == true)
                {
                    try
                    {
                        conn.Open();

                        string sqlInsert = "UPDATE Movies SET Genre_Id =@Genre_Id, Movie_Name=@Movie_Name, Length=@Length, Age_Restrict=@Age_Restrict, Year=@Year, Language=@Language, Description=@Description Where Movie_Id=@Movie_Id";

                        cmd = new SqlCommand(sqlInsert, conn);
                        cmd.Parameters.AddWithValue("@Movie_Id", MovieId);
                        cmd.Parameters.AddWithValue("@Genre_Id", CbxGenre.SelectedIndex.ToString());
                        cmd.Parameters.AddWithValue("@Movie_Name", TxtMovieName.Text);
                        cmd.Parameters.AddWithValue("@Length", TxtLength.Text);
                        cmd.Parameters.AddWithValue("@Age_Restrict", TxtAge.Text);
                        cmd.Parameters.AddWithValue("@Year", TxtYear.Text);
                        cmd.Parameters.AddWithValue("@Language", TxtLanguage.Text);
                        cmd.Parameters.AddWithValue("@Description", txtdes.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Edit Sucessfull");
                        Edit = false;
                        conn.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Unable to edit data, Please try agian");
                    }
                }
                else
                {
                    try
                    {
                        conn.Open();

                        String sql_Max = "SELECT Max(Movie_Id) FROM Movies";
                        cmd = new SqlCommand(sql_Max, conn);
                        int Num = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                        int ID = (int)Num + 1;

                        string sqlInsert = "INSERT INTO Movies VALUES(@ID,@GID,@Name,@Length,@Age,@Year,@Language,@Description)";

                        cmd = new SqlCommand(sqlInsert, conn);
                        cmd.Parameters.AddWithValue("@Id", ID);
                        cmd.Parameters.AddWithValue("@GID", CbxGenre.SelectedIndex.ToString());
                        cmd.Parameters.AddWithValue("@Name", TxtMovieName.Text);
                        cmd.Parameters.AddWithValue("@Length", TxtLength.Text);
                        cmd.Parameters.AddWithValue("@Age", TxtAge.Text);
                        cmd.Parameters.AddWithValue("@Year", TxtYear.Text);
                        cmd.Parameters.AddWithValue("@Language", TxtLanguage.Text);
                        cmd.Parameters.AddWithValue("@Description", txtdes.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("New Entry Entered");
                    }
                    catch
                    {
                        MessageBox.Show("Unable to Create data, Please try agian");
                    }

                }
                PopGridView("Movies");
                DGVMovies.DataSource = ds;
                DGVMovies.DataMember = "Data";
            }            

        }

        private void BtnAddGenre_Click(object sender, EventArgs e)
        {
            BtnAddGenre.Visible = false;        //Chris: Add genre Button
            btnDoneGenre.Visible = true;
            DGVGenres.Enabled = false;

            txtGenre.Text = "";
            txtGenre.Enabled = true;
        }

        private void DGVMovies_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                MovieId = Convert.ToInt16(DGVMovies.CurrentRow.Cells[0].Value.ToString());
                int GenreId = Convert.ToInt16(DGVMovies.CurrentRow.Cells[1].Value.ToString());
                string Name = DGVMovies.CurrentRow.Cells[2].Value.ToString();
                string Length = DGVMovies.CurrentRow.Cells[3].Value.ToString();
                string Age = DGVMovies.CurrentRow.Cells[4].Value.ToString();
                string Year = DGVMovies.CurrentRow.Cells[5].Value.ToString();
                string Language = DGVMovies.CurrentRow.Cells[6].Value.ToString();
                string des= DGVMovies.CurrentRow.Cells[7].Value.ToString();

                TxtMovieName.Text = Name;
                TxtLength.Text = Length;
                TxtAge.Text = Age;
                TxtYear.Text = Year;
                TxtLanguage.Text = Language;
                CbxGenre.SelectedIndex = GenreId;
                txtdes.Text = des;
            }
            catch
            {
                MessageBox.Show("Error, Please select a valid entry");
            }
        }

        private void btnReports_Click_1(object sender, EventArgs e)
        {
            TclAdmin.SelectedIndex = 7;         //Chris: Change tab to Reports
            BtnVisible();
            btnReports.Visible = false;

            cbxMovieViews.Items.Clear();

            popCbx("SELECT Movie_Name FROM Movies", cbxMovieViews);

        }

        private void BtnSceduleMovie_Click(object sender, EventArgs e)
        {
            EnabledSchedule(false);

            Edit = false;

            CBXTime.SelectedIndex = -1;
            CbxMovie.SelectedIndex = -1;
            CbxCinema.SelectedIndex = -1;
        }

        private void DGVSchedule_SelectionChanged(object sender, EventArgs e)
        {            
            try
            {
                ShowId = Convert.ToInt16(DGVSchedule.CurrentRow.Cells[0].Value.ToString());
                int MovId = Convert.ToInt16(DGVSchedule.CurrentRow.Cells[2].Value.ToString());      // Chris: Change selection Schedule movie
                int CinID = Convert.ToInt16(DGVSchedule.CurrentRow.Cells[1].Value.ToString());
                DateTime Date = (DateTime)DGVSchedule.CurrentRow.Cells[3].Value;
                string time = DGVSchedule.CurrentRow.Cells[4].Value.ToString();

                CbxCinema.SelectedIndex = CinID;
                CbxMovie.SelectedIndex = MovId;
                DtStart.Value = Date;
                if (time=="14:00")
                {
                    CBXTime.SelectedIndex = 0;
                }
                else
                {
                    if (time=="17:00")
                    {
                        CBXTime.SelectedIndex = 1;
                    }
                    else
                    {
                        CBXTime.SelectedIndex = 2;
                    }
                }
              
            }
            catch
            {
                MessageBox.Show("Error: Please try again");
                
            }
            
            
        }

        private void btnDoneGenre_Click(object sender, EventArgs e)
        {
            if (txtGenre.Text!="")
            {
                BtnAddGenre.Visible = true;     //Chris:Add genre to table button
                btnDoneGenre.Visible = false;
                DGVGenres.Enabled = true;

                txtGenre.Enabled = false;

                try
                {
                    conn.Open();

                    String sql_Max = "SELECT Max(Genre_Id) FROM Genres";
                    cmd = new SqlCommand(sql_Max, conn);
                    int Num = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                    int ID = (int)Num + 1;

                    string sqlInsert = "INSERT INTO Genres VALUES(@Genre_Id,@Description)";

                    cmd = new SqlCommand(sqlInsert, conn);
                    cmd.Parameters.AddWithValue("@Genre_Id", ID);
                    cmd.Parameters.AddWithValue("@Description", txtGenre.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("New Entry Entered");
                }
                catch
                {
                    MessageBox.Show("Unable to Create data, Please try agian");
                }

                PopGridView("Genres");
                DGVGenres.DataSource = ds;
                DGVGenres.DataMember = "Data";
            }
            else
            {
                MessageBox.Show("Please enter a New Genre Name");
            }

            
        }

        private void BtnEditSchedule_Click(object sender, EventArgs e)
        {
            EnabledSchedule(false);

            Edit = true;
        } 

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            EnabledUser(false);
            Edit = false;

            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void BtnDeleteSchedule_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to delete the selected row?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    string delete_query = "DELETE FROM ShowTimes WHERE Showing_Id='" + ShowId + "'";
                    conn = new SqlConnection(constr);
                    conn.Open();
                    cmd = new SqlCommand(delete_query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Viewing Deleted");

            }
            catch
            {
                MessageBox.Show("Error: Please try again");

            }

            PopGridView("ShowTimes");
            DGVSchedule.DataSource = ds;
            DGVSchedule.DataMember = "Data";
        }

        private void btnUserEdit_Click(object sender, EventArgs e)
        {
            EnabledUser(false);

            Edit = true;
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to delete the selected row?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    string delete_query = "DELETE FROM Users WHERE Id='" + UserId + "'";
                    conn = new SqlConnection(constr);
                    conn.Open();
                    cmd = new SqlCommand(delete_query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Viewing Deleted");

            }
            catch
            {
                MessageBox.Show("Error: Please try again");

            }

            PopGridView("Users");
            DGVUsers.DataSource = ds;
            DGVUsers.DataMember = "Data";
        }

        private void DGVUsers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                UserId = Convert.ToInt16(DGVUsers.CurrentRow.Cells[0].Value.ToString());
                string UserName = DGVUsers.CurrentRow.Cells[1].Value.ToString();      // Chris: Change selection Users
                string Password = DGVUsers.CurrentRow.Cells[2].Value.ToString();

                txtUsername.Text = UserName;
                txtPassword.Text = Password;
            }
            catch
            {
                MessageBox.Show("Error: Pleaes try again");                
            }



        }

        private void DGVBookings_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                BookId = Convert.ToInt16(DGVBookings.CurrentRow.Cells[0].Value.ToString());
                int Name = Convert.ToInt16(DGVBookings.CurrentRow.Cells[1].Value.ToString());      // Chris: Change selection Users
                int Movie = Convert.ToInt16(DGVBookings.CurrentRow.Cells[3].Value.ToString());
                string Seat = (DGVBookings.CurrentRow.Cells[4].Value.ToString());

                cbxMovView.SelectedIndex = Movie;
                cbxName.SelectedIndex = Name;
                CBXSurname.SelectedIndex = Name;
                txtSeats.Text = Seat;

            }
            catch
            {
                MessageBox.Show("Error: Pleaes try again");
            }
        }

        private void BtnEditBooking_Click(object sender, EventArgs e)
        {
            EnableBookings(false);
        }

        private void BtnDeleteBooking_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show("Booking Deleted Deleted");

            try
            {
                if (MessageBox.Show("Are you sure you want to delete the selected row?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    string delete_query = "DELETE FROM Bookings WHERE Booking_Id='" + BookId + "'";
                    conn = new SqlConnection(constr);
                    conn.Open();
                    cmd = new SqlCommand(delete_query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error: Please try again");

            }
            PopGridView("Bookings");
            DGVBookings.DataSource = ds;
            DGVBookings.DataMember = "Data";
        }

        private void BtnDoneBookings_Click(object sender, EventArgs e)
        {
            EnableBookings(true);

            try                     //Chris: Edit Booking
            {
                string sqlInsert = "UPDATE Bookings SET Seat_Code=@Seats Where Booking_Id=@Booking_Id";

                conn.Open();
                cmd = new SqlCommand(sqlInsert, conn);
                cmd.Parameters.AddWithValue("@Booking_Id", BookId);
                cmd.Parameters.AddWithValue("@Seats", txtSeats.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Edit Sucessfull");
                Edit = false;
            }
            catch
            {
                MessageBox.Show("Error: Please try agian");

            }
            PopGridView("Bookings");
            DGVBookings.DataSource = ds;
            DGVBookings.DataMember = "Data";

            EnableBookings(true);

        }

        private void BtnFilterBooking_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);       //Chris: Populate all data grid view
            conn.Open();
            string sql;
            adap = new SqlDataAdapter();
            ds = new DataSet();

            sql = @"SELECT * FROM Bookings WHERE Booking_Id='"+txtFilter.Text+"'";
            cmd = new SqlCommand(sql, conn);


            adap.SelectCommand = cmd;
            adap.Fill(ds, "Data");

            DGVBookings.DataSource = ds;
            DGVBookings.DataMember = "Data";

            conn.Close();
        }

        private void TclAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Index = TclAdmin.SelectedIndex;
            switch (Index)
            {
                case 0:
                    BtnHome.PerformClick();
                    break;
                case 1:
                    BtnClients.PerformClick();
                    break;
                case 2:
                    BtnMovies.PerformClick();
                    break;
                case 3:
                    BtnGenres.PerformClick();
                    break;
                case 4:
                    BtnScedule.PerformClick();
                    break;
                case 5:
                    BtnBookings.PerformClick();
                    break;
                case 6:
                    BtnUser.PerformClick();
                    break;
                case 7:
                    btnReports.PerformClick();
                    break;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int Movie;

            Movie = cbxMovieViews.SelectedIndex;

            lbxReport.Items.Clear();
            lbxReport.Items.Add("All time Report");
            lbxReport.Items.Add("");

            conn = new SqlConnection(constr);
            conn.Open();

            String sql_Total = "SELECT count(Booking_Id) FROM Bookings";
            cmd = new SqlCommand(sql_Total, conn);
            int Total = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            String sql_Seats = "SELECT Sum(Seat_Code) FROM Bookings";
            cmd = new SqlCommand(sql_Seats, conn);
            int totSeats = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            String sql_Movie = "SELECT count(Booking_Id) FROM Bookings WHERE Movie_id='"+Movie+"'";
            cmd = new SqlCommand(sql_Movie, conn);
            int TotMovie = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            //String sql_Genre = "SELECT count(Booking_Id) FROM Bookings WHERE Movie_id='" + Movie + "'";
            //cmd = new SqlCommand(sql_Movie, conn);
            //int TotGenre = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            conn.Close();

            lbxReport.Items.Add("Total Bookings: " + Total.ToString());            
            lbxReport.Items.Add("Total Seats Booked: " + totSeats.ToString());
            if (cbxMovieViews.SelectedIndex!=-1)
            {
                lbxReport.Items.Add("Total Bookings for " + cbxMovieViews.Text + ": " + TotMovie.ToString());
            }
                      
        }

        private void lblMovieViews_Click(object sender, EventArgs e)
        {

        }

        private void BtnUserDone_Click(object sender, EventArgs e)
        {
            EnabledUser(true);

            if (Edit == false)       //Chris: Add new
            {
                conn.Open();

                String sql_Max = "SELECT Max(Id) FROM Users";
                cmd = new SqlCommand(sql_Max, conn);
                int Num = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                int ID = (int)Num + 1;

                string sqlInsert = "INSERT INTO Users VALUES(@Id,@Username,@Password)";

                cmd = new SqlCommand(sqlInsert, conn);
                cmd.Parameters.AddWithValue("@Id", ID);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);                
                cmd.ExecuteNonQuery();
                conn.Close();

                try
                {
                    MessageBox.Show("New Entry Entered");
                }
                catch
                {
                    MessageBox.Show("Error: Please try agian");
                }
            }
            else
            {
                try                     //Chris: Edit Booking
                {
                    string sqlInsert = "UPDATE Users SET Username=@user, Password=@pass Where Id=@Id";

                    conn.Open();
                    cmd = new SqlCommand(sqlInsert, conn);
                    cmd.Parameters.AddWithValue("@Id", UserId);
                    cmd.Parameters.AddWithValue("@User", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Pass", txtPassword.Text);                   
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Edit Sucessfull");
                    Edit = false;
                }
                catch
                {
                    MessageBox.Show("Error: Please try agian");

                }

            }

            PopGridView("Users");
            DGVUsers.DataSource = ds;
            DGVUsers.DataMember = "Data";

        }

        private void btnViewDays_Click(object sender, EventArgs e)
        {
            int Movie, Genre;

            Movie = cbxMovieViews.SelectedIndex;

            lbxReport.Items.Clear();
            lbxReport.Items.Add("Report for the past 30 Days");
            lbxReport.Items.Add("");

            conn = new SqlConnection(constr);
            conn.Open();

            DateTime StartDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            StartDate = StartDate.AddDays(-30);

            string sql_Total = "SELECT count(Booking_Id) FROM Bookings WHERE Booking_For>'" + StartDate + "'";
            cmd = new SqlCommand(sql_Total, conn);
            int Total = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            string sql_Seats = "SELECT Sum(Seat_Code) FROM Bookings WHERE Booking_For>'" + StartDate + "'";
            cmd = new SqlCommand(sql_Seats, conn);
            int totSeats = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            string sql_Movie = "SELECT count(Booking_Id) FROM Bookings WHERE Movie_id='" + Movie + "' AND Booking_For>'" + StartDate + "'";
            cmd = new SqlCommand(sql_Movie, conn);
            int TotMovie = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            conn.Close();

            lbxReport.Items.Add("Total Bookings: " + Total.ToString());
            lbxReport.Items.Add("Total Seats Booked: " + totSeats.ToString());
            if (cbxMovieViews.SelectedIndex != -1)
            {
                lbxReport.Items.Add("Total Bookings for " + cbxMovieViews.Text + ": " + TotMovie.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDoneSchedule_Click(object sender, EventArgs e)
        {
            if (CbxCinema.SelectedIndex!=-1||CbxMovie.SelectedIndex != -1||CBXTime.SelectedIndex != -1)
            {                
                string time = "";
                bool valid = true;
                DateTime thisday = DateTime.Today;

                if (Delete == false||DtStart.Value>thisday)
                {
                    if (Edit == false)       //Chris: Add new
                    {
                        conn.Open();

                        String sql_Max = "SELECT Max(Showing_Id) FROM ShowTimes";
                        cmd = new SqlCommand(sql_Max, conn);
                        int Num = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                        int ID = (int)Num + 1;

                        switch (CBXTime.SelectedIndex)
                        {
                            case -1:
                                MessageBox.Show("Please select a time");
                                valid = false;
                                break;
                            case 0:
                                time = "14:00";
                                break;
                            case 1:
                                time = "17:00";
                                break;
                            case 2:
                                time = "20:00";
                                break;
                        }

                        string sqlInsert = "INSERT INTO ShowTimes VALUES(@Showing_Id,@Cinema_Id,@Movie_Id,@Date,@Time)";

                        cmd = new SqlCommand(sqlInsert, conn);
                        cmd.Parameters.AddWithValue("@Showing_Id", ID);
                        cmd.Parameters.AddWithValue("@Cinema_Id", CbxCinema.SelectedIndex);
                        cmd.Parameters.AddWithValue("@Movie_Id", CbxMovie.SelectedIndex);
                        cmd.Parameters.AddWithValue("@Date", DtStart.Value.ToShortDateString());
                        cmd.Parameters.AddWithValue("@Time", time);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        try
                        {
                            MessageBox.Show("New Entry Entered");
                        }
                        catch
                        {
                            MessageBox.Show("Error: Please try agian");
                        }
                    }
                    else
                    {
                        try                     //Chris: Edit Booking
                        {
                            string sqlInsert = "UPDATE ShowTimes SET Cinema_Id =@Cin, Movie_Id=@Mov, Date=@Date, Time=@Time Where Showing_Id=@Show";

                            conn.Open();
                            cmd = new SqlCommand(sqlInsert, conn);
                            cmd.Parameters.AddWithValue("@Show", ShowId);
                            cmd.Parameters.AddWithValue("@Cin", CbxCinema.SelectedIndex);
                            cmd.Parameters.AddWithValue("@Mov", CbxMovie.SelectedIndex);
                            cmd.Parameters.AddWithValue("@Date", DtStart.Value.Date);
                            cmd.Parameters.AddWithValue("@Time", CBXTime.SelectedIndex);
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Edit Sucessfull");
                            Edit = false;
                        }
                        catch
                        {
                            MessageBox.Show("Error: Please try agian");

                        }

                    }

                }

                EnabledSchedule(true);
                PopGridView("ShowTimes");
                DGVSchedule.DataSource = ds;
                DGVSchedule.DataMember = "Data";
            }

            
        }

        private void EnabledSchedule(bool Done)
        {
            if (Done==false)                //Chris: Enable/diable components Schedule
            {
                CbxCinema.Enabled = true;
                CbxMovie.Enabled = true;
                DtStart.Enabled = true;
                CBXTime.Enabled = true;

                BtnAddSchedule.Visible = false;
                BtnEditSchedule.Visible = false;
                BtnDeleteSchedule.Visible = false;
                btnDoneSchedule.Visible = true;

                DGVSchedule.Enabled = false;
            }
            else
            {
                CbxCinema.Enabled = false;
                CbxMovie.Enabled = false;
                DtStart.Enabled = false; 
                CBXTime.Enabled = false;

                BtnAddSchedule.Visible = true;
                BtnEditSchedule.Visible = true;
                BtnDeleteSchedule.Visible = true;
                btnDoneSchedule.Visible = false;

                DGVSchedule.Enabled = true;
            }
        }
        private void EnabledUser(bool Done)
        {
            if (true)
            {
                if (Done == false)                //Chris: Enable/disable components Schedule
                {
                    txtUsername.Enabled = true;
                    txtPassword.Enabled = true;

                    btnUserAdd.Visible = false;
                    btnUserDelete.Visible = false;
                    btnUserEdit.Visible = false;
                    BtnUserDone.Visible = true;

                    DGVUsers.Enabled = false;
                }
                else
                {
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;

                    btnUserAdd.Visible = true;
                    btnUserDelete.Visible = true;
                    btnUserEdit.Visible = true;
                    BtnUserDone.Visible = false;

                    DGVUsers.Enabled = true;
                }
            }
        }
        private void EnableBookings(bool Done)
        {
            if (true)
            {
                if (Done == false)                //Chris: Enable/disable components bookings
                {
                    //cbxName.Enabled = true;
                    //CBXSurname.Enabled = true;
                    //cbxMovView.Enabled = true;
                    txtSeats.Enabled = true;

                    
                    BtnDoneBookings.Visible = true;
                    BtnDeleteBooking.Visible = false;
                    BtnEditBooking.Visible = false;

                    DGVBookings.Enabled = false;
                }
                else
                {
                    cbxName.Enabled = false;
                    CBXSurname.Enabled = false;
                    cbxMovView.Enabled = false;
                    txtSeats.Enabled = false;


                    BtnDoneBookings.Visible = false;
                    BtnDeleteBooking.Visible = true;
                    BtnEditBooking.Visible = true;

                    DGVBookings.Enabled = true;
                }
            }
        }

        private void popCbx(string Sql, ComboBox cbx)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

            cmd = new SqlCommand(Sql, conn);
            adap.SelectCommand = cmd;
            adap.Fill(ds, "Data");
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cbx.Items.Add(dataReader.GetValue(0));
            }
            conn.Close();
        }

    }
}
