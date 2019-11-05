namespace Staj_Takip_Sistemi
{
    partial class AdminGirisSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGirisSayfasi));
            this.btGeriAdmin = new System.Windows.Forms.Button();
            this.btKapatAdmin = new System.Windows.Forms.Button();
            this.adminsifre_Un = new System.Windows.Forms.Label();
            this.btAdminGiris = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbAdminKullanici = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbAdminSifre = new System.Windows.Forms.TextBox();
            this.AdminHatirla = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGeriAdmin
            // 
            this.btGeriAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btGeriAdmin.BackgroundImage")));
            this.btGeriAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btGeriAdmin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btGeriAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btGeriAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGeriAdmin.Location = new System.Drawing.Point(334, 1);
            this.btGeriAdmin.Name = "btGeriAdmin";
            this.btGeriAdmin.Size = new System.Drawing.Size(30, 28);
            this.btGeriAdmin.TabIndex = 26;
            this.btGeriAdmin.UseVisualStyleBackColor = true;
            this.btGeriAdmin.Click += new System.EventHandler(this.btGeriAdmin_Click);
            // 
            // btKapatAdmin
            // 
            this.btKapatAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btKapatAdmin.BackgroundImage")));
            this.btKapatAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btKapatAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btKapatAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKapatAdmin.Location = new System.Drawing.Point(363, 1);
            this.btKapatAdmin.Name = "btKapatAdmin";
            this.btKapatAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btKapatAdmin.Size = new System.Drawing.Size(28, 28);
            this.btKapatAdmin.TabIndex = 25;
            this.btKapatAdmin.UseVisualStyleBackColor = true;
            this.btKapatAdmin.Click += new System.EventHandler(this.btKapatAdmin_Click);
            // 
            // adminsifre_Un
            // 
            this.adminsifre_Un.AutoSize = true;
            this.adminsifre_Un.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminsifre_Un.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.adminsifre_Un.Location = new System.Drawing.Point(141, 379);
            this.adminsifre_Un.Name = "adminsifre_Un";
            this.adminsifre_Un.Size = new System.Drawing.Size(121, 18);
            this.adminsifre_Un.TabIndex = 31;
            this.adminsifre_Un.Text = "Şifreyi unuttum";
            this.adminsifre_Un.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btAdminGiris
            // 
            this.btAdminGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btAdminGiris.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btAdminGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btAdminGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdminGiris.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btAdminGiris.ForeColor = System.Drawing.Color.DimGray;
            this.btAdminGiris.Location = new System.Drawing.Point(81, 230);
            this.btAdminGiris.Name = "btAdminGiris";
            this.btAdminGiris.Size = new System.Drawing.Size(225, 53);
            this.btAdminGiris.TabIndex = 30;
            this.btAdminGiris.Text = "Giriş";
            this.btAdminGiris.UseVisualStyleBackColor = false;
            this.btAdminGiris.Click += new System.EventHandler(this.btAdminGiris_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tbAdminKullanici);
            this.panel2.Location = new System.Drawing.Point(81, 71);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(225, 53);
            this.panel2.TabIndex = 29;
            // 
            // tbAdminKullanici
            // 
            this.tbAdminKullanici.BackColor = System.Drawing.Color.White;
            this.tbAdminKullanici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAdminKullanici.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdminKullanici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbAdminKullanici.Location = new System.Drawing.Point(7, 13);
            this.tbAdminKullanici.Margin = new System.Windows.Forms.Padding(4);
            this.tbAdminKullanici.Name = "tbAdminKullanici";
            this.tbAdminKullanici.Size = new System.Drawing.Size(211, 26);
            this.tbAdminKullanici.TabIndex = 3;
            this.tbAdminKullanici.Text = "Admin";
            this.tbAdminKullanici.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tbAdminSifre);
            this.panel1.Location = new System.Drawing.Point(81, 143);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(225, 53);
            this.panel1.TabIndex = 28;
            // 
            // tbAdminSifre
            // 
            this.tbAdminSifre.BackColor = System.Drawing.Color.White;
            this.tbAdminSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAdminSifre.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.tbAdminSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbAdminSifre.Location = new System.Drawing.Point(8, 13);
            this.tbAdminSifre.Margin = new System.Windows.Forms.Padding(4);
            this.tbAdminSifre.Name = "tbAdminSifre";
            this.tbAdminSifre.Size = new System.Drawing.Size(211, 26);
            this.tbAdminSifre.TabIndex = 4;
            this.tbAdminSifre.Text = "Sifre";
            this.tbAdminSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AdminHatirla
            // 
            this.AdminHatirla.AutoSize = true;
            this.AdminHatirla.BackColor = System.Drawing.Color.Transparent;
            this.AdminHatirla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AdminHatirla.Location = new System.Drawing.Point(144, 202);
            this.AdminHatirla.Name = "AdminHatirla";
            this.AdminHatirla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AdminHatirla.Size = new System.Drawing.Size(80, 17);
            this.AdminHatirla.TabIndex = 27;
            this.AdminHatirla.Text = "Beni Hatırla";
            this.AdminHatirla.UseVisualStyleBackColor = false;
            // 
            // AdminGirisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(392, 406);
            this.Controls.Add(this.adminsifre_Un);
            this.Controls.Add(this.btAdminGiris);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AdminHatirla);
            this.Controls.Add(this.btGeriAdmin);
            this.Controls.Add(this.btKapatAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminGirisSayfasi";
            this.Text = "AdminGirisSayfasi";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGeriAdmin;
        private System.Windows.Forms.Button btKapatAdmin;
        private System.Windows.Forms.Label adminsifre_Un;
        private System.Windows.Forms.Button btAdminGiris;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbAdminKullanici;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbAdminSifre;
        private System.Windows.Forms.CheckBox AdminHatirla;
    }
}