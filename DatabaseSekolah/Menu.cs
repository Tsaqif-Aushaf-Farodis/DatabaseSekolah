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
    public partial class Menu : Form
    {
        string connectionString = "data source = TSAQIFJR;database= sekolah;MultipleActiveResultSets= True;user ID= sa;password= 2021lulus;";
        SqlConnection koneksi = new SqlConnection(@"data source = TSAQIFJR;database=sekolah;MultipleActiveResultSets=True;User ID=sa;Password=2021lulus");
        public SqlCommand cmd;
        DataTable dt;
        DataRow dr;
        string code;
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GridView i = new GridView();
            i.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Object nilai = comboBoxMenu.SelectedItem;
            String menu = nilai.ToString();
            if (menu == "Daftar Siswa")
            {
                this.Hide();
                DataSiswa i = new DataSiswa();
                i.Show();
            }
            else if (menu == "Daftar Guru")
            {
                this.Hide();
                DataGuru i = new DataGuru();
                i.Show();
            }
            else if (menu == "Jadwal Pelajaran")
            {
                this.Hide();
                Jadwal i = new Jadwal();
                i.Show();
            }
            else if (menu == "SPP")
            {
                this.Hide();
                SPP i = new SPP();
                i.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignIn i = new SignIn();
            i.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            comboBoxMenu.Items.Add("Jadwal Pelajaran");
            //comboBoxMenu.Items.Add("Daftar Pelajaran");
            comboBoxMenu.Items.Add("Daftar Guru");
            comboBoxMenu.Items.Add("Daftar Siswa");
            //comboBoxMenu.Items.Add("Daftar Kelas");
            comboBoxMenu.Items.Add("SPP");
        }
        
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn i = new SignIn();
            i.Show();
        }
    }
}
