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
        public string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\MovieBookingProgram\DBTheater.mdf;Integrated Security=True";
        public int user;
        public SqlConnection conn;
        public SqlCommand cmd;
        public DataSet ds;
        public SqlDataAdapter adap;

        int clientId;

        public void ConnectDatabase()
        {
            conn = new SqlConnection(constr);
            conn.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

        }

        private void Reset()
        {
            cbxTime.Items.Clear();
            cbxMovie.Items.Clear();
            numSeats.Value = 0;
            cbxTime.Text = "";
            cbxTime.Enabled = false;

            ConnectDatabase();
            GrabDataCbx(@"SELECT Movie_Name FROM Movies", cbxMovie);
            conn.Close();
            rtbxOut.Clear();

            //User guidance
            btnBook.Enabled = false;
            gbxDateTime.Enabled = true;
            gbxMovie.Enabled = true;
            gbxTicket.Enabled = false;
            rtbxOut.Enabled = false;

            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            btnCheck.Enabled = true;

            txtdate.Enabled = false;

            txtFirstName.Text = "";
            txtLastName.Text = "";

            gbxDateTime.Visible = false;
            gbxMovie.Visible = false;
            gbxTicket.Visible = false;
            
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
                cbx.Items.Add(dataReader.GetValue(0));
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
            //conn.Open();
            cmd = new SqlCommand(sql, conn);
            adap.SelectCommand = cmd;
            adap.Fill(ds, "Data");
            SqlDataReader dataReader = cmd.ExecuteReader();
            //conn.Close();
            return dataReader.GetString(1);
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
            FrmWelcome wel = new FrmWelcome();
            wel.ShowDialog();
            this.Close();
        }

        private void Book_Load(object sender, EventArgs e)
        {
            Reset();

        }

        private void cbxMovie_SelectedIndexChanged(object sender, EventArgs e)
        {

            //ConnectDatabase();
            ////load movie description from database
            //GrabDataRtbx(@"SELECT Description FROM Movies WHERE Movie_Name = " + cbxMovie.SelectedItem, rtbxMovie); //NB: no such column yet
            ////load restriction
            //GrabDataLbl(@"SELECT Age_Restrict FROM Movies WHERE Movie_Name = " + cbxMovie.SelectedItem, lblRestriction);
            ////unload genre
            //cbxGenre.SelectedIndex = 0;
            ////allow booking
            //btnBook.Enabled = true;
            //conn.Close();

            if (cbxMovie.SelectedIndex!=-1)
            {
                gbxDateTime.Visible = true;
                popGridView();
                lblDateAndTime.Text = "Avalible dates and times for " + cbxMovie.Text;

                String sql_Des = "SELECT Description FROM Movies WHERE Movie_Id='"+cbxMovie.SelectedIndex+"'";
                conn.Open();
                cmd = new SqlCommand(sql_Des, conn);
                String Text = (cmd.ExecuteScalar().ToString());
                rtbxMovie.Text = Text;
                conn.Close();

                btnBook.Enabled = true;
            }
            else
            {
                gbxDateTime.Visible = false;    
            }
        }

        private void cbxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load movie names in genre
            //GrabDataCbx(@"SELECT Movie_Name FROM Movies WHERE Genre_Id = " + cbxGenre.SelectedItem, cbxMovie);
        }
       

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (numSeats.Value!=0)
            {
                ConnectDatabase();
                DialogResult result = MessageBox.Show("Do you want to check out?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    gbxDateTime.Enabled = false;
                    gbxMovie.Enabled = false;
                    gbxTicket.Enabled = true;
                    gbxDateTime.Visible = false;
                    gbxMovie.Visible = false;
                    gbxTicket.Visible = true;

                    //discuss how to generate the following:

                    //Booking_Id - autonumber

                    String sql_Max = "SELECT Max(Booking_Id) FROM Bookings";
                    cmd = new SqlCommand(sql_Max, conn);
                    int Booking_Id = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    Booking_Id++;

                    //Movie_Id
                    string Movie_Id = cbxMovie.SelectedItem.ToString();
                    //Booking_For
                    string Booking_For = txtdate.Text;
                    //Seat_Code - how should we keep track of available seats?
                    int Seat_Code = Int16.Parse(numSeats.Value.ToString());

                    //write to rich text - format?

                    rtbxOut.AppendText("Hello " + txtFirstName.Text + " " + txtLastName.Text + Environment.NewLine);
                    rtbxOut.AppendText("Booking number: " + Booking_Id + Environment.NewLine);
                    rtbxOut.AppendText("Movie: " + cbxMovie.Text + Environment.NewLine);
                    rtbxOut.AppendText("Date: " + txtdate.Text + Environment.NewLine);
                    rtbxOut.AppendText("Time: " + cbxTime.Text + Environment.NewLine);
                    rtbxOut.AppendText("Seats: " + Seat_Code + Environment.NewLine);
                    rtbxOut.AppendText("Price: R" + 50 * Seat_Code);//discuss prices


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

                    try
                    {
                        conn.Open();

                        string sqlInsert = "INSERT INTO Bookings VALUES(@Booking_ID,@Client_Id,@Booking_for,@Movie_id,@Seat_Code)";

                        cmd = new SqlCommand(sqlInsert, conn);
                        cmd.Parameters.AddWithValue("@Booking_Id", Booking_Id);
                        cmd.Parameters.AddWithValue("@Client_Id", clientId);
                        cmd.Parameters.AddWithValue("@Booking_for", dgvBookings.CurrentRow.Cells[0].Value);
                        cmd.Parameters.AddWithValue("@Movie_id", cbxMovie.SelectedIndex);
                        cmd.Parameters.AddWithValue("@Seat_Code", Seat_Code);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        btnBook.Enabled = false;
                    }
                    catch
                    {
                        MessageBox.Show("Unable to Create data, Please try agian");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select the number of seats");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool Found = false, good=true;
            string name=txtFirstName.Text, surname=txtLastName.Text;
            int count=-1;

            if ((txtFirstName.Text!="") || (txtLastName.Text!=""))
            {
                //check existance
                ConnectDatabase();
                cmd = new SqlCommand("SELECT First_Name, Last_Name FROM Clients", conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    count++;
                    string query = dataReader.GetString(0);
                    if (query == txtFirstName.Text)
                    {
                        string query2 = dataReader.GetString(1);
                        if (query2 == txtLastName.Text)
                        {
                            Found = true;
                            clientId = count;
                            name = query;
                            surname = query2;
                        }
                    }

                }
                conn.Close();

                if (Found == true)
                {
                    DialogResult result = MessageBox.Show("Username already exists. Continue?", "Warning!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Welcome, " + name + " " + surname);
                        txtFirstName.Enabled = false;
                        txtLastName.Enabled = false;
                        btnCheck.Enabled = false;

                        gbxMovie.Visible = true;
                    }
                }
                else
                {
                    String sql_Max = "SELECT Max(Client_Id) FROM Clients";
                    conn.Open();
                    cmd = new SqlCommand(sql_Max, conn);
                    clientId = Convert.ToInt32(cmd.ExecuteScalar().ToString()) + 1;
                    

                    string sqlInsert = "INSERT INTO Clients VALUES(@Client_Id,@First_name,@Last_name)";
                    
                    cmd = new SqlCommand(sqlInsert, conn);
                    cmd.Parameters.AddWithValue("@Client_Id", clientId);
                    cmd.Parameters.AddWithValue("@First_name", name);
                    cmd.Parameters.AddWithValue("@Last_name", surname);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Username Added!");
                    txtFirstName.Enabled = false;
                    txtLastName.Enabled = false;
                    btnCheck.Enabled = false;

                    gbxMovie.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please enter a your name and surname");
            }

            
        }
        private void popGridView()
        {
            conn = new SqlConnection(constr);       //Chris: Populate all data grid view
            conn.Open();
            string sql;
            adap = new SqlDataAdapter();
            ds = new DataSet();

            sql = @"SELECT Date,Time FROM ShowTimes WHERE Movie_Id='"+cbxMovie.SelectedIndex+"'";
            cmd = new SqlCommand(sql, conn);


            adap.SelectCommand = cmd;
            adap.Fill(ds, "Data");

            conn.Close();
            dgvBookings.DataSource = ds;
            dgvBookings.DataMember = "Data";
        }

        private void dgvBookings_SelectionChanged(object sender, EventArgs e)
        {
            cbxTime.Items.Clear();
            try
            {
                string time = (dgvBookings.CurrentRow.Cells[1].Value.ToString());
                string d = dgvBookings.CurrentRow.Cells[0].Value.ToString();
                string date = "";
                for (int i = 0; i < 10; i++)
                {
                    date += d[i];
                }

                cbxTime.Items.Clear();
                switch (time)
                {
                    case "14:00":
                        cbxTime.Text = "14:00-16:30";
                        break;
                    case "17:00":
                        cbxTime.Text = "17:00-19:30";
                        break;
                    case "20:00":
                        cbxTime.Text = "20:00-22:30";
                        break;
                }
                txtdate.Text = date;
                
            }
            catch
            {
                MessageBox.Show("Error, Please select a valid entry");
            }
        }
    }
}