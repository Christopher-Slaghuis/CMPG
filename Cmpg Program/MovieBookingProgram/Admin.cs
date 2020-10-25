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
        public string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\CMPG 223 Group Project\MovieBookingProgram\MovieBookingProgram\DBTheater.mdf;Integrated Security=True";

        public SqlConnection conn;
        public SqlCommand cmd;
        public DataSet ds;
        public SqlDataAdapter adap;

        public Admin()
        {
            InitializeComponent();

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
            TclAdmin.Enabled = false;
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
            TclAdmin.SelectedIndex = 0;
            BtnVisible();
            BtnHome.Visible = false;
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            TclAdmin.SelectedIndex = 1;
            BtnVisible();
            BtnClients.Visible = false;

            PopGridView("Clients");
        }

        private void BtnMovies_Click(object sender, EventArgs e)
        {
            TclAdmin.SelectedIndex = 2;
            BtnVisible();
            BtnMovies.Visible = false;

            PopGridView("Movies");
        }

        private void BtnGenres_Click(object sender, EventArgs e)
        {
            TclAdmin.SelectedIndex = 3;
            BtnVisible();
            BtnGenres.Visible = false;

            PopGridView("Genres");
        }

        private void BtnScedule_Click(object sender, EventArgs e)
        {
            TclAdmin.SelectedIndex = 4;
            BtnVisible();
            BtnScedule.Visible = false;
        }

        private void BtnBookings_Click(object sender, EventArgs e)
        {
            TclAdmin.SelectedIndex = 5;
            BtnVisible();
            BtnBookings.Visible = false;

            PopGridView("Bookings");
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            TclAdmin.SelectedIndex = 6;
            BtnVisible();
            BtnReports.Visible = false;
        }

        private void BtnVisible()
        {
            BtnHome.Visible = true;
            BtnClients.Visible = true;
            BtnMovies.Visible = true;
            BtnGenres.Visible = true;
            BtnScedule.Visible = true;
            BtnBookings.Visible = true;
            BtnReports.Visible = true;

        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            BtnAdd.Visible = true;
            btnEdit.Visible = true;
            btnDone.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            BtnAdd.Visible = false;
            btnEdit.Visible = false;
            btnDone.Visible = true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            BtnAdd.Visible = false;
            btnEdit.Visible = false;
            btnDone.Visible = true;
        }
        private void PopGridView(string table)
        {
            conn = new SqlConnection(constr);       //Populate data grid
            conn.Open();
            string sql;
            adap = new SqlDataAdapter();
            ds = new DataSet();

            sql = @"SELECT * FROM "+table;
            cmd = new SqlCommand(sql, conn);


            adap.SelectCommand = cmd;
            adap.Fill(ds, "Data");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Data";

            conn.Close();
        }

        private void BtnAddMovie_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditBooking_Click(object sender, EventArgs e)
        {

        }
    }
}
