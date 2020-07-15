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
    public partial class SPP : Form
    {
        string connectionString = "data source = TSAQIFJR;database= sekolah;MultipleActiveResultSets= True;user ID= sa;password= 2021lulus;";
        SqlConnection koneksi = new SqlConnection(@"data source = TSAQIFJR;database=sekolah;MultipleActiveResultSets=True;User ID=sa;Password=2021lulus");
        public SqlCommand cmd;
        DataTable dt;
        DataRow dr;
        string code;
        public SPP()
        {
            InitializeComponent();
        }

        private void SPP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sekolahDataSet.SPP' table. You can move, or remove it, as needed.
            this.sPPTableAdapter.Fill(this.sekolahDataSet.SPP);
            btn_insert.Enabled = false;
            //btn_update.Enabled = true;
            //btn_delete.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            btn_insert.Enabled = true;
            txt_noKwitansi.Enabled = true;
            dateTimePickerBayar.Enabled = true;
            txt_totalBayar.Enabled = true;
            txt_nis.Enabled = true;
            txt_noKwitansi.Text = "";
            dateTimePickerBayar.Text = "";
            txt_totalBayar.Text = "";
            txt_nis.Text = "";
            int len;
            dt = sekolahDataSet.Tables["SPP"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["No_Kwitansi"].ToString();

            //btn_update.Enabled = false;
            //btn_delete.Enabled = false;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM SPP";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet("SPP");

            adapter.Fill(ds, "SPP");
            DataRow row = ds.Tables["SPP"].NewRow();
            row["No_Kwitansi"] = txt_noKwitansi.Text;
            row["Tgl_Bayar"] = dateTimePickerBayar.Text;
            row["Total_Bayar"] = txt_totalBayar.Text;
            row["NIS"] = txt_nis.Text;
            ds.Tables["SPP"].Rows.Add(row);
            adapter.Update(ds, "SPP");
            connection.Close();

            sPPTableAdapter.Update(sekolahDataSet);
            txt_noKwitansi.Enabled = false; ;
            dateTimePickerBayar.Enabled = false;
            txt_totalBayar.Enabled = false;
            txt_nis.Enabled = false;
            this.sPPTableAdapter.Fill(this.sekolahDataSet.SPP);
            //btn_update.Enabled = true;
            //btn_delete.Enabled = true;
            MessageBox.Show("Data berhasil disimpan!");
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
            SPP i = new SPP();
            i.Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [SPP] where No_Kwitansi = '" + txt_noKwitansi.Text + "'";
            cmd.ExecuteNonQuery();
            koneksi.Close();
            txt_noKwitansi.Text = "";
            dateTimePickerBayar.Text = "";
            txt_totalBayar.Text = "";
            txt_nis.Text = "";
            MessageBox.Show(" Data berhasil dihapus!");
        }
    }
}
