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
    public partial class GridView : Form
    {
        string connectionString = "data source = TSAQIFJR;database= sekolah;MultipleActiveResultSets= True;user ID= sa;password= 2021lulus;";
        SqlConnection koneksi = new SqlConnection(@"data source = TSAQIFJR;database=sekolah;MultipleActiveResultSets=True;User ID=sa;Password=2021lulus");
        public SqlCommand cmd;
        DataTable dt;
        DataRow dr;
        string code;
        public GridView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login i = new Login();
            i.Show();
        }

        private void GridView_Load(object sender, EventArgs e)
        {
            comboBoxGrid.Items.Add("Jadwal Pelajaran");
            comboBoxGrid.Items.Add("Daftar Pelajaran");
            comboBoxGrid.Items.Add("Daftar Guru");
            comboBoxGrid.Items.Add("Daftar Siswa");
            comboBoxGrid.Items.Add("Daftar Kelas");
            comboBoxGrid.Items.Add("SPP");

            dataGridViewMurid.Visible = true;
            dataGridViewGuru.Visible = false;
            dataGridViewMapel.Visible = false;
            dataGridViewKelas.Visible = false;
            dataGridViewJadwal.Visible = false;
            dataGridViewSPP.Visible = false;
        }

        private void comboBoxGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object nilai = comboBoxGrid.SelectedItem;
            String menu = nilai.ToString();
            if (menu == "Daftar Siswa")
            {
                this.siswaTableAdapter.Fill(this.sekolahDataSet.Siswa);
                dataGridViewMurid.Visible = true;
                dataGridViewGuru.Visible = false;
                dataGridViewMapel.Visible = false;
                dataGridViewKelas.Visible = false;
                dataGridViewJadwal.Visible = false;
                dataGridViewSPP.Visible = false;
            }
            else if (menu == "Daftar Guru")
            {
                this.guruTableAdapter.Fill(this.sekolahDataSet.Guru);
                dataGridViewMurid.Visible = false;
                dataGridViewGuru.Visible = true;
                dataGridViewMapel.Visible = false;
                dataGridViewKelas.Visible = false;
                dataGridViewJadwal.Visible = false;
                dataGridViewSPP.Visible = false;
            }
            else if (menu == "Daftar Pelajaran")
            {
                this.mata_PelajaranTableAdapter.Fill(this.sekolahDataSet.Mata_Pelajaran);
                dataGridViewMurid.Visible = false;
                dataGridViewGuru.Visible = false;
                dataGridViewMapel.Visible = true;
                dataGridViewKelas.Visible = false;
                dataGridViewJadwal.Visible = false;
                dataGridViewSPP.Visible = false;
            }
            else if (menu == "Daftar Kelas")
            {
                this.kelasTableAdapter.Fill(this.sekolahDataSet.Kelas);
                dataGridViewMurid.Visible = false;
                dataGridViewGuru.Visible = false;
                dataGridViewMapel.Visible = false;
                dataGridViewKelas.Visible = true;
                dataGridViewJadwal.Visible = false;
                dataGridViewSPP.Visible = false;
            }
            else if (menu == "Jadwal Pelajaran")
            {
                this.jadwal_GuruTableAdapter.Fill(this.sekolahDataSet.Jadwal_Guru);
                dataGridViewMurid.Visible = false;
                dataGridViewGuru.Visible = false;
                dataGridViewMapel.Visible = false;
                dataGridViewKelas.Visible = false;
                dataGridViewJadwal.Visible = true;
                dataGridViewSPP.Visible = false;
            }
            else if (menu == "SPP")
            {
                this.sPPTableAdapter.Fill(this.sekolahDataSet.SPP);
                dataGridViewMurid.Visible = false;
                dataGridViewGuru.Visible = false;
                dataGridViewMapel.Visible = false;
                dataGridViewKelas.Visible = false;
                dataGridViewJadwal.Visible = false;
                dataGridViewSPP.Visible = true;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.Hide();
            GridView i = new GridView();
            i.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Object nilai = comboBoxGrid.SelectedItem;
            String menu = nilai.ToString();
            if (menu == "Daftar Siswa")
            {
                SqlDataAdapter DA = new SqlDataAdapter("select * from Siswa where Nama_Siswa like '%" + txt_search.Text + "%'", koneksi);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridViewMurid.DataSource = DS.Tables[0];
            }
            else if(menu == "Daftar Guru")
            {
                SqlDataAdapter DA = new SqlDataAdapter("select * from Guru where Nama_Guru like '%" + txt_search.Text + "%'", koneksi);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridViewGuru.DataSource = DS.Tables[0];
            }
            else if (menu == "Daftar Pelajaran")
            {
                SqlDataAdapter DA = new SqlDataAdapter("select * from Mata_Pelajaran where Nama_Mapel like '%" + txt_search.Text + "%'", koneksi);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridViewMapel.DataSource = DS.Tables[0];
            }
            else if (menu == "Daftar Kelas")
            {
                SqlDataAdapter DA = new SqlDataAdapter("select * from Kelas where Kelas like '%" + txt_search.Text + "%'", koneksi);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridViewKelas.DataSource = DS.Tables[0];
            }
            else if (menu == "Jadwal Pelajaran")
            {
                SqlDataAdapter DA = new SqlDataAdapter("select * from Jadwal_Guru where Hari like '%" + txt_search.Text + "%'", koneksi);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridViewJadwal.DataSource = DS.Tables[0];
            }
            else if (menu == "SPP")
            {
                SqlDataAdapter DA = new SqlDataAdapter("select * from SPP where NIS like '%" + txt_search.Text + "%'", koneksi);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridViewSPP.DataSource = DS.Tables[0];
            }
        }
    }
}
