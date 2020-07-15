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
    public partial class RegisterAdmin : Form
    {
        string connectionString = "data source = TSAQIFJR;database= sekolah;MultipleActiveResultSets= True;user ID= sa;password= 2021lulus;";
        SqlConnection koneksi = new SqlConnection(@"data source = TSAQIFJR;database=sekolah;MultipleActiveResultSets=True;User ID=sa;Password=2021lulus");
        SqlCommand cmd;
        DataTable dt;
        DataRow dr;
        string code;

        public RegisterAdmin()
        {
            InitializeComponent();
        }

        private void RegisterAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sekolahDataSet.Admin_TU' table. You can move, or remove it, as needed.
            this.admin_TUTableAdapter.Fill(this.sekolahDataSet.Admin_TU);
            txt_username.Enabled = true;
            txt_password.Enabled = true;
            txt_confirmPassword.Enabled = true;
            txt_username.Text = "";
            txt_password.Text = "";
            txt_confirmPassword.Text = "";
            int ctr, len;
            string codeval;
            dt = sekolahDataSet.Tables["Admin_TU"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["Username"].ToString();
            codeval = code.Substring(1, 3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn i = new SignIn();
            i.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Admin_TU";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet("Admin_TU");

            if (txt_password.Text == txt_confirmPassword.Text)
            {
                adapter.Fill(ds, "Admin_TU");
                DataRow row = ds.Tables["Admin_TU"].NewRow();
                row["Username"] = txt_username.Text;
                row["Password"] = txt_password.Text;
                ds.Tables["Admin_TU"].Rows.Add(row);
                adapter.Update(ds, "Admin_TU");
                connection.Close();
                admin_TUTableAdapter.Update(sekolahDataSet);
                this.admin_TUTableAdapter.Fill(this.sekolahDataSet.Admin_TU);
                txt_username.Enabled = false;
                txt_password.Enabled = false;
                txt_confirmPassword.Enabled = false;
                MessageBox.Show("Data Berhasil Disimpan!");
                this.Hide();
                SignIn i = new SignIn();
                i.Show();
            }
            else
            {
                MessageBox.Show("Password yang anda masukkan tidak sama!");
            }
        }
    }
}
