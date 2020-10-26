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
    public partial class LogIn : Form
    {       
        public string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\MovieBookingProgram\DBTheater.mdf;Integrated Security=True";

        public SqlConnection conn;
        public SqlCommand cmd;

        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string Username = "", Password = "";
            string dbUser = "", DbPassword = "";
            bool UserFound = false;
            bool Match = false;

            Username = txtUserName.Text;
            Password = TxtPassword.Text;

            if (Username==""||Password=="")
            {
                MessageBox.Show("Please enter both a Username and Password");
            }

            conn = new SqlConnection(constr);
            SqlDataReader Rdr;
            String sql_Max = "SELECT * FROM Users";
            cmd = new SqlCommand(sql_Max, conn);

            conn.Open();

            Rdr = cmd.ExecuteReader();

            if (Rdr.HasRows)
            {
                while (Rdr.Read())
                {
                    dbUser = Rdr["Username"].ToString();
                    DbPassword = Rdr["Password"].ToString();

                    if (dbUser==Username)
                    {
                        UserFound = true;
                        if (DbPassword==Password)
                        {
                            Match = true;
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password");
                        }
                    }                    
                }
            }

            conn.Close();

            if (UserFound==false)
            {
                MessageBox.Show("User Not found");
            }
            if (Match==true)
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }
            
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FrmWelcome well = new FrmWelcome();
            well.Show();
            this.Hide();
        }

        private void lblLogIn_Click(object sender, EventArgs e)
        {

        }
    }
}
