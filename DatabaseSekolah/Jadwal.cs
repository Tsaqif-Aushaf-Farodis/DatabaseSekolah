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
    public partial class Jadwal : Form
    {
        string connectionString = "data source = TSAQIFJR;database= sekolah;MultipleActiveResultSets= True;user ID= sa;password= 2021lulus;";
        SqlConnection koneksi = new SqlConnection(@"data source = TSAQIFJR;database=sekolah;MultipleActiveResultSets=True;User ID=sa;Password=2021lulus");
        public SqlCommand cmd;
        DataTable dt;
        DataRow dr;
        string code;
        public Jadwal()
        {
            InitializeComponent();
        }

        private void Jadwal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sekolahDataSet.Jadwal_Guru' table. You can move, or remove it, as needed.
            this.jadwal_GuruTableAdapter.Fill(this.sekolahDataSet.Jadwal_Guru);
            btn_insert.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;

            comboBoxHari.Items.Add("Senin");
            comboBoxHari.Items.Add("Selasa");
            comboBoxHari.Items.Add("Rabu");
            comboBoxHari.Items.Add("Kamis");
            comboBoxHari.Items.Add("Jumat");
            comboBoxHari.Items.Add("Sabtu");
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Jadwal_Guru";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet("Jadwal_Guru");

            adapter.Fill(ds, "Jadwal_Guru");
            DataRow row = ds.Tables["Jadwal_Guru"].NewRow();
            row["Kode_Jadwal"] = txt_kodeJadwal.Text;
            row["Kode_Mapel"] = txt_kodeMapel.Text;
            row["Kode_Guru"] = txt_kodeGuru.Text;
            row["Kelas"] = txt_kelas.Text;
            row["Hari"] = comboBoxHari.Text;
            row["Jam"] = txt_jam.Text;
            
            ds.Tables["Jadwal_Guru"].Rows.Add(row);
            adapter.Update(ds, "Jadwal_Guru");
            connection.Close();

            jadwal_GuruTableAdapter.Update(sekolahDataSet);
            txt_kodeJadwal.Enabled = false;
            txt_kodeMapel.Enabled = false;
            txt_kodeGuru.Enabled = false;
            txt_kelas.Enabled = false;
            comboBoxHari.Enabled = false;
            txt_jam.Enabled = false;
            
            this.jadwal_GuruTableAdapter.Fill(this.sekolahDataSet.Jadwal_Guru);
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
            MessageBox.Show("Data berhasil disimpan!");
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            btn_insert.Enabled = true;
            txt_kodeJadwal.Enabled = true;
            txt_kodeMapel.Enabled = true;
            txt_kodeGuru.Enabled = true;
            txt_kelas.Enabled = true;
            comboBoxHari.Enabled = true;
            txt_jam.Enabled = true;
            txt_kodeJadwal.Text = "";
            txt_kodeMapel.Text = "";
            txt_kodeGuru.Text = "";
            txt_kelas.Text = "";
            comboBoxHari.Text = "";
            txt_jam.Text = "";
            int len;
            dt = sekolahDataSet.Tables["Jadwal_Guru"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["Kode_Jadwal"].ToString();

            btn_update.Enabled = false;
            btn_delete.Enabled = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            if (txt_kodeGuru.Text != "")
            {
                cmd = new SqlCommand("update Jadwal_Guru set Kode_Mapel=@Kode_Mapel, Kode_Guru=@Kode_Guru, Kelas=@Kelas, Hari=@Hari, Jam=@Jam where Kode_Jadwal=@Kode_Jadwal", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@Kode_Jadwal", txt_kodeJadwal.Text);
                cmd.Parameters.AddWithValue("@Kode_Mapel", txt_kodeMapel.Text);
                cmd.Parameters.AddWithValue("@Kode_Guru", txt_kodeGuru.Text);
                cmd.Parameters.AddWithValue("@Kelas", txt_kelas.Text);
                cmd.Parameters.AddWithValue("@Hari", comboBoxHari.Text);
                cmd.Parameters.AddWithValue("@Jam", txt_jam.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di update");
                connection.Close();
            }
            else
            {
                MessageBox.Show("Harap isi data yang kosong!");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Jadwal_Guru] where Kode_Jadwal = '" + txt_kodeJadwal.Text + "'";
            cmd.ExecuteNonQuery();
            koneksi.Close();
            txt_kodeJadwal.Text = "";
            txt_kodeMapel.Text = "";
            txt_kodeGuru.Text = "";
            txt_kelas.Text = "";
            comboBoxHari.Text = "";
            txt_jam.Text = "";
            MessageBox.Show(" Data berhasil dihapus!");
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Jadwal_Guru] where Kode_Jadwal = '" + txt_kodeJadwal.Text + "'";
            cmd.ExecuteNonQuery();
            koneksi.Close();
            txt_kodeJadwal.Text = "";
            txt_kodeMapel.Text = "";
            txt_kodeGuru.Text = "";
            txt_kelas.Text = "";
            comboBoxHari.Text = "";
            txt_jam.Text = "";
            MessageBox.Show(" Data berhasil dihapus!");
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu i = new Menu();
            i.Show();
        }

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Jadwal i = new Jadwal();
            i.Show();
        }
    }
}
