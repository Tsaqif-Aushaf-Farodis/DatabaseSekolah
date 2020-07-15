namespace DatabaseSekolah
{
    partial class GridView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridView));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMurid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.comboBoxGrid = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dataGridViewGuru = new System.Windows.Forms.DataGridView();
            this.dataGridViewMapel = new System.Windows.Forms.DataGridView();
            this.dataGridViewKelas = new System.Windows.Forms.DataGridView();
            this.dataGridViewJadwal = new System.Windows.Forms.DataGridView();
            this.Kode_Jadwal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kode_Mapel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSPP = new System.Windows.Forms.DataGridView();
            this.noKwitansiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglBayarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBayarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nISDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sekolahDataSet = new DatabaseSekolah.sekolahDataSet();
            this.kodeMapelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jadwalGuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kelasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruanganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahMuridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kelasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kodeMapelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaMapelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahJamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mataPelajaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Kode_Guru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_Guru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Telp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaSiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siswaTableAdapter = new DatabaseSekolah.sekolahDataSetTableAdapters.SiswaTableAdapter();
            this.guruTableAdapter = new DatabaseSekolah.sekolahDataSetTableAdapters.GuruTableAdapter();
            this.mata_PelajaranTableAdapter = new DatabaseSekolah.sekolahDataSetTableAdapters.Mata_PelajaranTableAdapter();
            this.kelasTableAdapter = new DatabaseSekolah.sekolahDataSetTableAdapters.KelasTableAdapter();
            this.mataPelajaranBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jadwal_GuruTableAdapter = new DatabaseSekolah.sekolahDataSetTableAdapters.Jadwal_GuruTableAdapter();
            this.sPPTableAdapter = new DatabaseSekolah.sekolahDataSetTableAdapters.SPPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMurid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJadwal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekolahDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalGuruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataPelajaranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataPelajaranBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rosewood Std Regular", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 47);
            this.label1.TabIndex = 14;
            this.label1.Text = "Database";
            // 
            // dataGridViewMurid
            // 
            this.dataGridViewMurid.AutoGenerateColumns = false;
            this.dataGridViewMurid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMurid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nISDataGridViewTextBoxColumn,
            this.namaSiswaDataGridViewTextBoxColumn,
            this.tTLDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.jenisKelaminDataGridViewTextBoxColumn,
            this.kelasDataGridViewTextBoxColumn});
            this.dataGridViewMurid.DataSource = this.siswaBindingSource;
            this.dataGridViewMurid.Location = new System.Drawing.Point(76, 138);
            this.dataGridViewMurid.Name = "dataGridViewMurid";
            this.dataGridViewMurid.RowTemplate.Height = 28;
            this.dataGridViewMurid.Size = new System.Drawing.Size(645, 300);
            this.dataGridViewMurid.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(76, 92);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(315, 26);
            this.txt_search.TabIndex = 17;
            this.txt_search.Text = "Search";
            this.txt_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBoxGrid
            // 
            this.comboBoxGrid.FormattingEnabled = true;
            this.comboBoxGrid.Location = new System.Drawing.Point(406, 90);
            this.comboBoxGrid.Name = "comboBoxGrid";
            this.comboBoxGrid.Size = new System.Drawing.Size(315, 28);
            this.comboBoxGrid.TabIndex = 18;
            this.comboBoxGrid.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrid_SelectedIndexChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_refresh.BackgroundImage")));
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refresh.Location = new System.Drawing.Point(76, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(50, 50);
            this.btn_refresh.TabIndex = 31;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dataGridViewGuru
            // 
            this.dataGridViewGuru.AutoGenerateColumns = false;
            this.dataGridViewGuru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuru.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kode_Guru,
            this.Nama_Guru,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.No_Telp});
            this.dataGridViewGuru.DataSource = this.guruBindingSource;
            this.dataGridViewGuru.Location = new System.Drawing.Point(76, 138);
            this.dataGridViewGuru.Name = "dataGridViewGuru";
            this.dataGridViewGuru.RowTemplate.Height = 28;
            this.dataGridViewGuru.Size = new System.Drawing.Size(645, 300);
            this.dataGridViewGuru.TabIndex = 19;
            // 
            // dataGridViewMapel
            // 
            this.dataGridViewMapel.AutoGenerateColumns = false;
            this.dataGridViewMapel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMapel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeMapelDataGridViewTextBoxColumn,
            this.namaMapelDataGridViewTextBoxColumn,
            this.jumlahJamDataGridViewTextBoxColumn});
            this.dataGridViewMapel.DataSource = this.mataPelajaranBindingSource;
            this.dataGridViewMapel.Location = new System.Drawing.Point(76, 138);
            this.dataGridViewMapel.Name = "dataGridViewMapel";
            this.dataGridViewMapel.RowTemplate.Height = 28;
            this.dataGridViewMapel.Size = new System.Drawing.Size(645, 300);
            this.dataGridViewMapel.TabIndex = 32;
            // 
            // dataGridViewKelas
            // 
            this.dataGridViewKelas.AutoGenerateColumns = false;
            this.dataGridViewKelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kelasDataGridViewTextBoxColumn1,
            this.ruanganDataGridViewTextBoxColumn,
            this.jumlahMuridDataGridViewTextBoxColumn});
            this.dataGridViewKelas.DataSource = this.kelasBindingSource;
            this.dataGridViewKelas.Location = new System.Drawing.Point(76, 138);
            this.dataGridViewKelas.Name = "dataGridViewKelas";
            this.dataGridViewKelas.RowTemplate.Height = 28;
            this.dataGridViewKelas.Size = new System.Drawing.Size(645, 300);
            this.dataGridViewKelas.TabIndex = 33;
            // 
            // dataGridViewJadwal
            // 
            this.dataGridViewJadwal.AutoGenerateColumns = false;
            this.dataGridViewJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJadwal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeMapelDataGridViewTextBoxColumn1,
            this.Kode_Jadwal,
            this.Kode_Mapel,
            this.dataGridViewTextBoxColumn1,
            this.Kelas,
            this.Hari,
            this.Jam});
            this.dataGridViewJadwal.DataSource = this.jadwalGuruBindingSource;
            this.dataGridViewJadwal.Location = new System.Drawing.Point(76, 138);
            this.dataGridViewJadwal.Name = "dataGridViewJadwal";
            this.dataGridViewJadwal.RowTemplate.Height = 28;
            this.dataGridViewJadwal.Size = new System.Drawing.Size(645, 300);
            this.dataGridViewJadwal.TabIndex = 34;
            // 
            // Kode_Jadwal
            // 
            this.Kode_Jadwal.DataPropertyName = "Kode_Jadwal";
            this.Kode_Jadwal.HeaderText = "Kode_Jadwal";
            this.Kode_Jadwal.Name = "Kode_Jadwal";
            // 
            // Kode_Mapel
            // 
            this.Kode_Mapel.DataPropertyName = "Kode_Mapel";
            this.Kode_Mapel.HeaderText = "Kode_Mapel";
            this.Kode_Mapel.Name = "Kode_Mapel";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Kode_Guru";
            this.dataGridViewTextBoxColumn1.HeaderText = "Kode_Guru";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Kelas
            // 
            this.Kelas.DataPropertyName = "Kelas";
            this.Kelas.HeaderText = "Kelas";
            this.Kelas.Name = "Kelas";
            // 
            // Hari
            // 
            this.Hari.DataPropertyName = "Hari";
            this.Hari.HeaderText = "Hari";
            this.Hari.Name = "Hari";
            // 
            // Jam
            // 
            this.Jam.DataPropertyName = "Jam";
            this.Jam.HeaderText = "Jam";
            this.Jam.Name = "Jam";
            // 
            // dataGridViewSPP
            // 
            this.dataGridViewSPP.AutoGenerateColumns = false;
            this.dataGridViewSPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSPP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noKwitansiDataGridViewTextBoxColumn,
            this.tglBayarDataGridViewTextBoxColumn,
            this.totalBayarDataGridViewTextBoxColumn,
            this.nISDataGridViewTextBoxColumn1});
            this.dataGridViewSPP.DataSource = this.sPPBindingSource;
            this.dataGridViewSPP.Location = new System.Drawing.Point(76, 138);
            this.dataGridViewSPP.Name = "dataGridViewSPP";
            this.dataGridViewSPP.RowTemplate.Height = 28;
            this.dataGridViewSPP.Size = new System.Drawing.Size(645, 300);
            this.dataGridViewSPP.TabIndex = 35;
            // 
            // noKwitansiDataGridViewTextBoxColumn
            // 
            this.noKwitansiDataGridViewTextBoxColumn.DataPropertyName = "No_Kwitansi";
            this.noKwitansiDataGridViewTextBoxColumn.HeaderText = "No_Kwitansi";
            this.noKwitansiDataGridViewTextBoxColumn.Name = "noKwitansiDataGridViewTextBoxColumn";
            // 
            // tglBayarDataGridViewTextBoxColumn
            // 
            this.tglBayarDataGridViewTextBoxColumn.DataPropertyName = "Tgl_Bayar";
            this.tglBayarDataGridViewTextBoxColumn.HeaderText = "Tgl_Bayar";
            this.tglBayarDataGridViewTextBoxColumn.Name = "tglBayarDataGridViewTextBoxColumn";
            // 
            // totalBayarDataGridViewTextBoxColumn
            // 
            this.totalBayarDataGridViewTextBoxColumn.DataPropertyName = "Total_Bayar";
            this.totalBayarDataGridViewTextBoxColumn.HeaderText = "Total_Bayar";
            this.totalBayarDataGridViewTextBoxColumn.Name = "totalBayarDataGridViewTextBoxColumn";
            // 
            // nISDataGridViewTextBoxColumn1
            // 
            this.nISDataGridViewTextBoxColumn1.DataPropertyName = "NIS";
            this.nISDataGridViewTextBoxColumn1.HeaderText = "NIS";
            this.nISDataGridViewTextBoxColumn1.Name = "nISDataGridViewTextBoxColumn1";
            // 
            // sPPBindingSource
            // 
            this.sPPBindingSource.DataMember = "SPP";
            this.sPPBindingSource.DataSource = this.sekolahDataSet;
            // 
            // sekolahDataSet
            // 
            this.sekolahDataSet.DataSetName = "sekolahDataSet";
            this.sekolahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kodeMapelDataGridViewTextBoxColumn1
            // 
            this.kodeMapelDataGridViewTextBoxColumn1.DataPropertyName = "Kode_Mapel";
            this.kodeMapelDataGridViewTextBoxColumn1.HeaderText = "Kode_Mapel";
            this.kodeMapelDataGridViewTextBoxColumn1.Name = "kodeMapelDataGridViewTextBoxColumn1";
            // 
            // jadwalGuruBindingSource
            // 
            this.jadwalGuruBindingSource.DataMember = "Jadwal_Guru";
            this.jadwalGuruBindingSource.DataSource = this.sekolahDataSet;
            // 
            // kelasDataGridViewTextBoxColumn1
            // 
            this.kelasDataGridViewTextBoxColumn1.DataPropertyName = "Kelas";
            this.kelasDataGridViewTextBoxColumn1.HeaderText = "Kelas";
            this.kelasDataGridViewTextBoxColumn1.Name = "kelasDataGridViewTextBoxColumn1";
            // 
            // ruanganDataGridViewTextBoxColumn
            // 
            this.ruanganDataGridViewTextBoxColumn.DataPropertyName = "Ruangan";
            this.ruanganDataGridViewTextBoxColumn.HeaderText = "Ruangan";
            this.ruanganDataGridViewTextBoxColumn.Name = "ruanganDataGridViewTextBoxColumn";
            // 
            // jumlahMuridDataGridViewTextBoxColumn
            // 
            this.jumlahMuridDataGridViewTextBoxColumn.DataPropertyName = "Jumlah_Murid";
            this.jumlahMuridDataGridViewTextBoxColumn.HeaderText = "Jumlah_Murid";
            this.jumlahMuridDataGridViewTextBoxColumn.Name = "jumlahMuridDataGridViewTextBoxColumn";
            // 
            // kelasBindingSource
            // 
            this.kelasBindingSource.DataMember = "Kelas";
            this.kelasBindingSource.DataSource = this.sekolahDataSet;
            // 
            // kodeMapelDataGridViewTextBoxColumn
            // 
            this.kodeMapelDataGridViewTextBoxColumn.DataPropertyName = "Kode_Mapel";
            this.kodeMapelDataGridViewTextBoxColumn.HeaderText = "Kode_Mapel";
            this.kodeMapelDataGridViewTextBoxColumn.Name = "kodeMapelDataGridViewTextBoxColumn";
            // 
            // namaMapelDataGridViewTextBoxColumn
            // 
            this.namaMapelDataGridViewTextBoxColumn.DataPropertyName = "Nama_Mapel";
            this.namaMapelDataGridViewTextBoxColumn.HeaderText = "Nama_Mapel";
            this.namaMapelDataGridViewTextBoxColumn.Name = "namaMapelDataGridViewTextBoxColumn";
            // 
            // jumlahJamDataGridViewTextBoxColumn
            // 
            this.jumlahJamDataGridViewTextBoxColumn.DataPropertyName = "Jumlah_Jam";
            this.jumlahJamDataGridViewTextBoxColumn.HeaderText = "Jumlah_Jam";
            this.jumlahJamDataGridViewTextBoxColumn.Name = "jumlahJamDataGridViewTextBoxColumn";
            // 
            // mataPelajaranBindingSource
            // 
            this.mataPelajaranBindingSource.DataMember = "Mata_Pelajaran";
            this.mataPelajaranBindingSource.DataSource = this.sekolahDataSet;
            // 
            // Kode_Guru
            // 
            this.Kode_Guru.DataPropertyName = "Kode_Guru";
            this.Kode_Guru.HeaderText = "Kode_Guru";
            this.Kode_Guru.Name = "Kode_Guru";
            // 
            // Nama_Guru
            // 
            this.Nama_Guru.DataPropertyName = "Nama_Guru";
            this.Nama_Guru.HeaderText = "Nama_Guru";
            this.Nama_Guru.Name = "Nama_Guru";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Alamat";
            this.dataGridViewTextBoxColumn4.HeaderText = "Alamat";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TTL";
            this.dataGridViewTextBoxColumn3.HeaderText = "TTL";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Jenis_Kelamin";
            this.dataGridViewTextBoxColumn5.HeaderText = "Jenis_Kelamin";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // No_Telp
            // 
            this.No_Telp.DataPropertyName = "No_Telp";
            this.No_Telp.HeaderText = "No_Telp";
            this.No_Telp.Name = "No_Telp";
            // 
            // guruBindingSource
            // 
            this.guruBindingSource.DataMember = "Guru";
            this.guruBindingSource.DataSource = this.sekolahDataSet;
            // 
            // nISDataGridViewTextBoxColumn
            // 
            this.nISDataGridViewTextBoxColumn.DataPropertyName = "NIS";
            this.nISDataGridViewTextBoxColumn.HeaderText = "NIS";
            this.nISDataGridViewTextBoxColumn.Name = "nISDataGridViewTextBoxColumn";
            // 
            // namaSiswaDataGridViewTextBoxColumn
            // 
            this.namaSiswaDataGridViewTextBoxColumn.DataPropertyName = "Nama_Siswa";
            this.namaSiswaDataGridViewTextBoxColumn.HeaderText = "Nama_Siswa";
            this.namaSiswaDataGridViewTextBoxColumn.Name = "namaSiswaDataGridViewTextBoxColumn";
            // 
            // tTLDataGridViewTextBoxColumn
            // 
            this.tTLDataGridViewTextBoxColumn.DataPropertyName = "TTL";
            this.tTLDataGridViewTextBoxColumn.HeaderText = "TTL";
            this.tTLDataGridViewTextBoxColumn.Name = "tTLDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // jenisKelaminDataGridViewTextBoxColumn
            // 
            this.jenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.HeaderText = "Jenis_Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.Name = "jenisKelaminDataGridViewTextBoxColumn";
            // 
            // kelasDataGridViewTextBoxColumn
            // 
            this.kelasDataGridViewTextBoxColumn.DataPropertyName = "Kelas";
            this.kelasDataGridViewTextBoxColumn.HeaderText = "Kelas";
            this.kelasDataGridViewTextBoxColumn.Name = "kelasDataGridViewTextBoxColumn";
            // 
            // siswaBindingSource
            // 
            this.siswaBindingSource.DataMember = "Siswa";
            this.siswaBindingSource.DataSource = this.sekolahDataSet;
            // 
            // siswaTableAdapter
            // 
            this.siswaTableAdapter.ClearBeforeFill = true;
            // 
            // guruTableAdapter
            // 
            this.guruTableAdapter.ClearBeforeFill = true;
            // 
            // mata_PelajaranTableAdapter
            // 
            this.mata_PelajaranTableAdapter.ClearBeforeFill = true;
            // 
            // kelasTableAdapter
            // 
            this.kelasTableAdapter.ClearBeforeFill = true;
            // 
            // mataPelajaranBindingSource1
            // 
            this.mataPelajaranBindingSource1.DataMember = "Mata_Pelajaran";
            this.mataPelajaranBindingSource1.DataSource = this.sekolahDataSet;
            // 
            // jadwal_GuruTableAdapter
            // 
            this.jadwal_GuruTableAdapter.ClearBeforeFill = true;
            // 
            // sPPTableAdapter
            // 
            this.sPPTableAdapter.ClearBeforeFill = true;
            // 
            // GridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewSPP);
            this.Controls.Add(this.dataGridViewJadwal);
            this.Controls.Add(this.dataGridViewKelas);
            this.Controls.Add(this.dataGridViewMapel);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.dataGridViewGuru);
            this.Controls.Add(this.comboBoxGrid);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewMurid);
            this.Controls.Add(this.label1);
            this.Name = "GridView";
            this.Text = "GridView";
            this.Load += new System.EventHandler(this.GridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMurid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJadwal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekolahDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalGuruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataPelajaranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataPelajaranBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMurid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox comboBoxGrid;
        private sekolahDataSet sekolahDataSet;
        private System.Windows.Forms.BindingSource siswaBindingSource;
        private sekolahDataSetTableAdapters.SiswaTableAdapter siswaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaSiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelasDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource guruBindingSource;
        private sekolahDataSetTableAdapters.GuruTableAdapter guruTableAdapter;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dataGridViewGuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kode_Guru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_Guru;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Telp;
        private System.Windows.Forms.DataGridView dataGridViewMapel;
        private System.Windows.Forms.BindingSource mataPelajaranBindingSource;
        private sekolahDataSetTableAdapters.Mata_PelajaranTableAdapter mata_PelajaranTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeMapelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMapelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahJamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewKelas;
        private System.Windows.Forms.BindingSource kelasBindingSource;
        private sekolahDataSetTableAdapters.KelasTableAdapter kelasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelasDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruanganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahMuridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewJadwal;
        private System.Windows.Forms.BindingSource mataPelajaranBindingSource1;
        private System.Windows.Forms.BindingSource jadwalGuruBindingSource;
        private sekolahDataSetTableAdapters.Jadwal_GuruTableAdapter jadwal_GuruTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeMapelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kode_Jadwal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kode_Mapel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hari;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jam;
        private System.Windows.Forms.DataGridView dataGridViewSPP;
        private System.Windows.Forms.BindingSource sPPBindingSource;
        private sekolahDataSetTableAdapters.SPPTableAdapter sPPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noKwitansiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglBayarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBayarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nISDataGridViewTextBoxColumn1;
    }
}