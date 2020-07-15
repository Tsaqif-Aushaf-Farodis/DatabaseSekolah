namespace DatabaseSekolah
{
    partial class RegisterAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.adminTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sekolahDataSet = new DatabaseSekolah.sekolahDataSet();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_confirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.admin_TUTableAdapter = new DatabaseSekolah.sekolahDataSetTableAdapters.Admin_TUTableAdapter();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminTUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekolahDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rosewood Std Regular", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 47);
            this.label1.TabIndex = 13;
            this.label1.Text = "Register Admin";
            // 
            // txt_password
            // 
            this.txt_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminTUBindingSource, "Password", true));
            this.txt_password.Location = new System.Drawing.Point(246, 219);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(300, 26);
            this.txt_password.TabIndex = 17;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // adminTUBindingSource
            // 
            this.adminTUBindingSource.DataMember = "Admin_TU";
            this.adminTUBindingSource.DataSource = this.sekolahDataSet;
            // 
            // sekolahDataSet
            // 
            this.sekolahDataSet.DataSetName = "sekolahDataSet";
            this.sekolahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_username
            // 
            this.txt_username.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminTUBindingSource, "Username", true));
            this.txt_username.Location = new System.Drawing.Point(246, 149);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(300, 26);
            this.txt_username.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Username :";
            // 
            // txt_confirmPassword
            // 
            this.txt_confirmPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminTUBindingSource, "Password", true));
            this.txt_confirmPassword.Location = new System.Drawing.Point(246, 292);
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.Size = new System.Drawing.Size(300, 26);
            this.txt_confirmPassword.TabIndex = 19;
            this.txt_confirmPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Confirm Password :";
            // 
            // admin_TUTableAdapter
            // 
            this.admin_TUTableAdapter.ClearBeforeFill = true;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.Lime;
            this.btn_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_register.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(406, 353);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(140, 50);
            this.btn_register.TabIndex = 25;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_cancel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(246, 353);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(140, 50);
            this.btn_cancel.TabIndex = 26;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_confirmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterAdmin";
            this.Text = "RegisterAdmin";
            this.Load += new System.EventHandler(this.RegisterAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminTUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekolahDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_confirmPassword;
        private System.Windows.Forms.Label label4;
        private sekolahDataSet sekolahDataSet;
        private System.Windows.Forms.BindingSource adminTUBindingSource;
        private sekolahDataSetTableAdapters.Admin_TUTableAdapter admin_TUTableAdapter;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_cancel;
    }
}