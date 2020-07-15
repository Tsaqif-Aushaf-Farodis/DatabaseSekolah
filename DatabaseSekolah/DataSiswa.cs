using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSekolah
{
    public partial class DataSiswa : Form
    {
        string connectionString = "data source = TSAQIFJR;database= sekolah;MultipleActiveResultSets= True;user ID= sa;password= 2021lulus;";
        SqlConnection koneksi = new SqlConnection(@"data source = TSAQIFJR;database=sekolah;MultipleActiveResultSets=True;User ID=sa;Password=2021lulus");
        public SqlCommand cmd;
        DataTable dt;
        DataRow dr;
        string code;

        public DataSiswa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu i = new Menu();
            i.Show();
        }

        private void DataSiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sekolahDataSet.Siswa' table. You can move, or remove it, as needed.
            this.siswaTableAdapter.Fill(this.sekolahDataSet.Siswa);
            btn_insert.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
            comboBoxJK.Items.Add("L");
            comboBoxJK.Items.Add("P");
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            btn_insert.Enabled = true;
            txt_nis.Enabled = true;
            txt_nama.Enabled = true;
            txt_ttl.Enabled = true;
            txt_alamat.Enabled = true;
            comboBoxJK.Enabled = true;
            txt_kelas.Enabled = true;
            txt_nis.Text = "";
            txt_nama.Text = "";
            txt_ttl.Text = "";
            txt_alamat.Text = "";
            comboBoxJK.Text = "";
            txt_kelas.Text = "";
            int ctr, len;
            string codeval;
            dt = sekolahDataSet.Tables["Siswa"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["NIS"].ToString();
            codeval = code.Substring(1, 3);
            ctr = Convert.ToInt32(codeval);
            
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Siswa";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet("Siswa");

            adapter.Fill(ds, "Siswa");
            DataRow row = ds.Tables["Siswa"].NewRow();
            row["NIS"] = txt_nis.Text;
            row["Nama_Siswa"] = txt_nama.Text;
            row["TTL"] = txt_ttl.Text;
            row["Alamat"] = txt_alamat.Text;
            row["Jenis_Kelamin"] = comboBoxJK.Text;
            row["Kelas"] = txt_kelas.Text;
            ds.Tables["Siswa"].Rows.Add(row);
            adapter.Update(ds, "Siswa");
            connection.Close();

            siswaTableAdapter.Update(sekolahDataSet);
            txt_nis.Enabled = false; ;
            txt_nama.Enabled = false;
            txt_ttl.Enabled = false;
            txt_alamat.Enabled = false;
            comboBoxJK.Enabled = false;
            txt_kelas.Enabled = false;
            this.siswaTableAdapter.Fill(this.sekolahDataSet.Siswa);
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
            MessageBox.Show("Data berhasil disimpan!");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Siswa] where NIS = '" + txt_nis.Text + "'";
            cmd.ExecuteNonQuery();
            koneksi.Close();
            txt_nis.Text = "";
            txt_nama.Text = "";
            txt_ttl.Text = "";
            txt_alamat.Text = "";
            comboBoxJK.Text = "";
            txt_kelas.Text = "";
            MessageBox.Show(" Data berhasil dihapus!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataSiswa i = new DataSiswa();
            i.Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Siswa] where NIS = '" + txt_nis.Text + "'";
            cmd.ExecuteNonQuery();
            koneksi.Close();
            txt_nis.Text = "";
            txt_nama.Text = "";
            txt_ttl.Text = "";
            txt_alamat.Text = "";
            comboBoxJK.Text = "";
            txt_kelas.Text = "";
            MessageBox.Show(" Data berhasil dihapus");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            if (txt_nis.Text != "")
            {
                cmd = new SqlCommand("update Siswa set Nama_Siswa=@Nama_Siswa, TTL=@TTL, Alamat=@Alamat, Jenis_Kelamin=@Jenis_Kelamin, Kelas=@Kelas where NIS=@NIS", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@NIS", txt_nis.Text);
                cmd.Parameters.AddWithValue("@Nama_Siswa", txt_nama.Text);
                cmd.Parameters.AddWithValue("@TTL", txt_ttl.Text);
                cmd.Parameters.AddWithValue("@Alamat", txt_alamat.Text);
                cmd.Parameters.AddWithValue("@Jenis_Kelamin", comboBoxJK.Text);
                cmd.Parameters.AddWithValue("@Kelas", txt_kelas.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di update");
                connection.Close();
            }
            else
            {
                MessageBox.Show("Harap isi data yang kosong!");
            }
        }

        private void display_data()
        {
            SqlDataAdapter DA = new SqlDataAdapter("select * from Siswa", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
        }
    }
}
