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
    public partial class Book : Form
    {
        //different file path
        public string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Uni\CMPG223\Project\CMPG Assignment\2020_10_17_Basic_Layout\CMPG 223 Group Project\MovieBookingProgram\MovieBookingProgram\DBTheater.mdf;Integrated Security=True";
        public int user;
        public SqlConnection conn;
        public SqlCommand cmd;
        public DataSet ds;
        public SqlDataAdapter adap;

        public void ConnectDatabase()
        {
            conn = new SqlConnection(constr);
            conn.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

        }

        private void Reset()
        {
            ConnectDatabase();
            GrabDataCbx(@"SELECT Special_Id FROM Specials", cbxSpecial);
            GrabDataCbx(@"SELECT Movie_Name FROM Movies", cbxMovie);
            GrabDataCbx(@"SELECT Description FROM Genres", cbxGenre);
            conn.Close();
            rtbxOut.Clear();

            //User guidance
            btnBook.Enabled = false;
            gbxDateTime.Enabled = true;
            gbxMovie.Enabled = true;
            gbxTicket.Enabled = false;

            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            btnCheck.Enabled = true;
        }

        private void GrabDataCbx(string sql, ComboBox cbx)
        {
            ConnectDatabase();
            cmd = new SqlCommand(sql, conn);
            adap.SelectCommand = cmd;
            adap.Fill(ds, "Data");
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cbx.Items.Add(dataReader.GetValue(1));
            }
            conn.Close();
        }
        private void GrabDataRtbx(string sql, RichTextBox rtbx)
        {
            ConnectDatabase();
            cmd = new SqlCommand(sql, conn);
            adap.SelectCommand = cmd;
            adap.Fill(ds, "Data");
            SqlDataReader dataReader = cmd.ExecuteReader();

            rtbx.Text = dataReader.GetString(1);
            conn.Close();
        }
        private void GrabDataLbl(string sql, Label lbl)
        {
            ConnectDatabase();
            cmd = new SqlCommand(sql, conn);
            adap.SelectCommand = cmd;
            adap.Fill(ds, "Data");
            SqlDataReader dataReader = cmd.ExecuteReader();

            lbl.Text = dataReader.GetString(1);
            conn.Close();
        }

        private string GrabData(string sql)
        {
            ConnectDatabase();
            cmd = new SqlCommand(sql, conn);
            adap.SelectCommand = cmd;
            adap.Fill(ds, "Data");
            SqlDataReader dataReader = cmd.ExecuteReader();

            return dataReader.GetString(1);
            conn.Close();
        }


        public Book()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gbxTime_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Book_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome user!");

            Reset();

        }

        private void cbxMovie_SelectedIndexChanged(object sender, EventArgs e)
        {

            ConnectDatabase();
            //load movie description from database
            GrabDataRtbx(@"SELECT Description FROM Movies WHERE Movie_Name = " + cbxMovie.SelectedItem, rtbxMovie); //NB: no such column yet
            //load restriction
            GrabDataLbl(@"SELECT Age_Restrict FROM Movies WHERE Movie_Name = " + cbxMovie.SelectedItem, lblRestriction);
            //unload genre
            cbxGenre.SelectedIndex = 0;
            //allow booking
            btnBook.Enabled = true;
            conn.Close();
        }

        private void cbxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load movie names in genre
            GrabDataCbx(@"SELECT Movie_Name FROM Movies WHERE Genre_Id = " + cbxGenre.SelectedItem, cbxMovie);
        }

        private void cbxSpecial_SelectedIndexChanged(object sender, EventArgs e)
        {

            ConnectDatabase();
            GrabDataCbx(@"SELECT Movie_Name FROM Movies WHERE  Genre_Id= " + cbxSpecial.SelectedItem, cbxMovie);
            GrabDataRtbx(@"SELECT Description FROM Specials", rtbxSpecial);
            GrabDataLbl(@"SELECT Price FROM Specials WHERE Special_Id = " + cbxSpecial.SelectedItem, lblSpecialPrice);
            conn.Close();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            ConnectDatabase();
            DialogResult result = MessageBox.Show("Do you want to check out?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                gbxDateTime.Enabled = false;
                gbxMovie.Enabled = false;
                gbxTicket.Enabled = true;

                //discuss how to generate the following:

                //Booking_Id - autonumber
                int Booking_Id = Int16.Parse(GrabData("SELECT MAX(Booking_Id) FROM Bookings")) + 1;
                //Client_Id - autonumber
                int Client_Id = Int16.Parse(GrabData("SELECT MAX(Client_Id) FROM Clients")) + 1;
                //Special_Id
                string Special_Id = cbxSpecial.SelectedItem.ToString();
                //Movie_Id
                string Movie_Id = GrabData(@"SELECT Movie_Id FROM Movies WHERE Movie_Name = " + cbxMovie.SelectedItem);
                //Booking_For
                string Booking_For = GrabData("SELECT ??? FROM Show_Times WHERE Movie_Id =" + Movie_Id);
                //Seat_Code - how should we keep track of available seats?
                int Seat_Code = Int16.Parse(numSeats.Value.ToString());

                //write to rich text - format?

                rtbxOut.AppendText("Hello! " + GrabData("SELECT First_Name FROM Clients WHERE Client_Id = " + user));
                rtbxOut.AppendText("Booking number: " + Booking_Id);
                rtbxOut.AppendText("Movie: " + cbxMovie.SelectedItem);
                rtbxOut.AppendText("Time: " + Booking_For);
                rtbxOut.AppendText("Seats: " + Seat_Code);
                rtbxOut.AppendText("Price: ???");//discuss prices


                //Payment
                //Dont have required hardware to present over zoom meeting, rtf would be printed on "slips" to give to the customer?
                //Future expansion - sms "slips" to customer

                //write to database - formatting?
                //ConnectDatabase();
                //string sql = "INSERT INTO DBTheater.Bookings (Booking_Id,Client_Id,Special_Id, Booking_For, Movie_Id, Seat_Code,Payment) values()";
                //cmd = new SqlCommand(sql, conn);
                //adap.InsertCommand = new SqlCommand(sql, conn);
                //adap.InsertCommand.ExecuteNonQuery();

                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //check existance
            ConnectDatabase();
            cmd = new SqlCommand("SELECT First_Name, Last_Name FROM Clients", conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                string query = dataReader.GetString(1);
                if (query == txtFirstName.Text)
                {
                    string query2 = dataReader.GetString(2);
                    if (query == txtLastName.Text)
                    {
                        DialogResult result = MessageBox.Show("Username already exists. Continue?", "Warning!", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            user = Int16.Parse(GrabData("SELECT Client_Id FROM Clients WHERE First_name =" + query + "&& Last_name = " + query2));
                            MessageBox.Show("Welcome, " + GrabData("SELECT First_Name FROM Clients WHERE Client_Id =" + user));
                            txtFirstName.Enabled = false;
                            txtLastName.Enabled = false;
                            btnCheck.Enabled = false;
                        }
                    }
                    else
                    {
                        user = Int16.Parse(GrabData("SELECT MAX(Client_Id) FROM Clients")) + 1;
                        adap.InsertCommand = new SqlCommand("INSERT INTO DBTheater.Clients(Client_Id,First_name,Last_name) values (" + GrabData("SELECT MAX(Client_Id) FROM Clients" + 1) + "," + txtFirstName.Text + "," + txtLastName.Text);
                        MessageBox.Show("Username Added!");
                        txtFirstName.Enabled = false;
                        txtLastName.Enabled = false;
                        btnCheck.Enabled = false;
                    }

                }

            }
            conn.Close();
        }
    }
}