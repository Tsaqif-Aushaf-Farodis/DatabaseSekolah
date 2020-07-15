using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSekolah
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login i = new Login();
            i.Show();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            string cs = "Data Source = localhost; Initial Catalog = sekolah; " + "Integrated Security = True;";
            //validasi login.
            if (txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Please Check Your Username and Password");
                return;
            }
            try
            {
                //Membuat SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("select * from Admin_TU where Username=@Username and Password=@Password", con);
                cmd.Parameters.AddWithValue("@Username", txt_username.Text);
                cmd.Parameters.AddWithValue("@Password", txt_password.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {
                    //pindah ke Form2
                    this.Hide();
                    Menu i = new Menu();
                    i.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterAdmin i = new RegisterAdmin();
            i.Show();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
