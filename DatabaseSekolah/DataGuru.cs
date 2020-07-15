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
    public partial class DataGuru : Form
    {
        string connectionString = "data source = TSAQIFJR;database= sekolah;MultipleActiveResultSets= True;user ID= sa;password= 2021lulus;";
        SqlConnection koneksi = new SqlConnection(@"data source = TSAQIFJR;database=sekolah;MultipleActiveResultSets=True;User ID=sa;Password=2021lulus");
        public SqlCommand cmd;
        DataTable dt;
        DataRow dr;
        string code;
        public DataGuru()
        {
            InitializeComponent();
        }

        private void DataGuru_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sekolahDataSet.Guru' table. You can move, or remove it, as needed.
            this.guruTableAdapter.Fill(this.sekolahDataSet.Guru);
            btn_insert.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
            comboBoxJK.Items.Add("L");
            comboBoxJK.Items.Add("P");

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Guru";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet("Guru");

            adapter.Fill(ds, "Guru");
            DataRow row = ds.Tables["Guru"].NewRow();
            row["Kode_Guru"] = txt_kodeGuru.Text;
            row["Nama_Guru"] = txt_nama.Text;
            row["TTL"] = txt_ttl.Text;
            row["Alamat"] = txt_alamat.Text;
            row["Jenis_Kelamin"] = comboBoxJK.Text;
            row["No_Telp"] = txt_noTelp.Text;
            ds.Tables["Guru"].Rows.Add(row);
            adapter.Update(ds, "Guru");
            connection.Close();

            guruTableAdapter.Update(sekolahDataSet);
            txt_kodeGuru.Enabled = false; ;
            txt_nama.Enabled = false;
            txt_ttl.Enabled = false;
            txt_alamat.Enabled = false;
            comboBoxJK.Enabled = false;
            txt_noTelp.Enabled = false;
            this.guruTableAdapter.Fill(this.sekolahDataSet.Guru);
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
            MessageBox.Show("Data berhasil disimpan!");
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            btn_insert.Enabled = true;
            txt_kodeGuru.Enabled = true;
            txt_nama.Enabled = true;
            txt_ttl.Enabled = true;
            txt_alamat.Enabled = true;
            comboBoxJK.Enabled = true;
            txt_noTelp.Enabled = true;
            txt_kodeGuru.Text = "";
            txt_nama.Text = "";
            txt_ttl.Text = "";
            txt_alamat.Text = "";
            comboBoxJK.Text = "";
            txt_noTelp.Text = "";
            int len;
            dt = sekolahDataSet.Tables["Guru"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["Kode_Guru"].ToString();

            btn_update.Enabled = false;
            btn_delete.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Guru] where Kode_Guru = '" + txt_kodeGuru.Text + "'";
            cmd.ExecuteNonQuery();
            koneksi.Close();
            txt_kodeGuru.Text = "";
            txt_nama.Text = "";
            txt_ttl.Text = "";
            txt_alamat.Text = "";
            comboBoxJK.Text = "";
            txt_noTelp.Text = "";
            MessageBox.Show(" Data berhasil dihapus!");
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Guru] where Kode_Guru = '" + txt_kodeGuru.Text + "'";
            cmd.ExecuteNonQuery();
            koneksi.Close();
            txt_kodeGuru.Text = "";
            txt_nama.Text = "";
            txt_ttl.Text = "";
            txt_alamat.Text = "";
            comboBoxJK.Text = "";
            txt_noTelp.Text = "";
            MessageBox.Show(" Data berhasil dihapus!");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu i = new Menu();
            i.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataGuru i = new DataGuru();
            i.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            if (txt_kodeGuru.Text != "")
            {
                cmd = new SqlCommand("update Guru set Nama_Guru=@Nama_Guru, TTL=@TTL, Alamat=@Alamat, Jenis_Kelamin=@Jenis_Kelamin, No_Telp=@No_Telp where Kode_Guru=@Kode_Guru", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@Kode_Guru", txt_kodeGuru.Text);
                cmd.Parameters.AddWithValue("@Nama_Guru", txt_nama.Text);
                cmd.Parameters.AddWithValue("@TTL", txt_ttl.Text);
                cmd.Parameters.AddWithValue("@Alamat", txt_alamat.Text);
                cmd.Parameters.AddWithValue("@Jenis_Kelamin", comboBoxJK.Text);
                cmd.Parameters.AddWithValue("@No_Telp", txt_noTelp.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di update");
                connection.Close();
            }
            else
            {
                MessageBox.Show("Harap isi data yang kosong!");
            }
        }
    }
}
