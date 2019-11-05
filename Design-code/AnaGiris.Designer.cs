namespace Staj_Takip_Sistemi
{
    partial class AnaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaGiris));
            this.ogrenciGiris = new System.Windows.Forms.Button();
            this.akademisyenGirisi = new System.Windows.Forms.Button();
            this.adminGiris = new System.Windows.Forms.Button();
            this.AnaGirisPanelüst = new System.Windows.Forms.Panel();
            this.btAnagirisKapat = new System.Windows.Forms.Button();
            this.adminResim = new System.Windows.Forms.PictureBox();
            this.akademisyenResim = new System.Windows.Forms.PictureBox();
            this.ogrResim = new System.Windows.Forms.PictureBox();
            this.AnaGirisPanelAlt = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.AnaGirisPanelüst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akademisyenResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrResim)).BeginInit();
            this.AnaGirisPanelAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrenciGiris
            // 
            this.ogrenciGiris.BackColor = System.Drawing.Color.White;
            this.ogrenciGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ogrenciGiris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ogrenciGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ogrenciGiris.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogrenciGiris.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ogrenciGiris.Location = new System.Drawing.Point(51, 3);
            this.ogrenciGiris.Name = "ogrenciGiris";
            this.ogrenciGiris.Size = new System.Drawing.Size(260, 58);
            this.ogrenciGiris.TabIndex = 0;
            this.ogrenciGiris.Text = "Öğrenci";
            this.ogrenciGiris.UseVisualStyleBackColor = false;
            this.ogrenciGiris.Click += new System.EventHandler(this.ogrenciGiris_Click);
            // 
            // akademisyenGirisi
            // 
            this.akademisyenGirisi.BackColor = System.Drawing.Color.White;
            this.akademisyenGirisi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.akademisyenGirisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.akademisyenGirisi.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.akademisyenGirisi.ForeColor = System.Drawing.Color.SaddleBrown;
            this.akademisyenGirisi.Location = new System.Drawing.Point(334, 4);
            this.akademisyenGirisi.Name = "akademisyenGirisi";
            this.akademisyenGirisi.Size = new System.Drawing.Size(260, 58);
            this.akademisyenGirisi.TabIndex = 1;
            this.akademisyenGirisi.Text = "Akademisyen";
            this.akademisyenGirisi.UseVisualStyleBackColor = false;
            this.akademisyenGirisi.Click += new System.EventHandler(this.akademisyenGirisi_Click);
            // 
            // adminGiris
            // 
            this.adminGiris.BackColor = System.Drawing.Color.White;
            this.adminGiris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.adminGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminGiris.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminGiris.ForeColor = System.Drawing.Color.SaddleBrown;
            this.adminGiris.Location = new System.Drawing.Point(614, 4);
            this.adminGiris.Name = "adminGiris";
            this.adminGiris.Size = new System.Drawing.Size(260, 58);
            this.adminGiris.TabIndex = 2;
            this.adminGiris.Text = "Yönetici";
            this.adminGiris.UseVisualStyleBackColor = false;
            this.adminGiris.Click += new System.EventHandler(this.adminGiris_Click);
            // 
            // AnaGirisPanelüst
            // 
            this.AnaGirisPanelüst.BackColor = System.Drawing.Color.White;
            this.AnaGirisPanelüst.Controls.Add(this.btAnagirisKapat);
            this.AnaGirisPanelüst.Controls.Add(this.adminResim);
            this.AnaGirisPanelüst.Controls.Add(this.akademisyenResim);
            this.AnaGirisPanelüst.Controls.Add(this.ogrResim);
            this.AnaGirisPanelüst.Location = new System.Drawing.Point(142, 45);
            this.AnaGirisPanelüst.Name = "AnaGirisPanelüst";
            this.AnaGirisPanelüst.Size = new System.Drawing.Size(925, 321);
            this.AnaGirisPanelüst.TabIndex = 5;
            // 
            // btAnagirisKapat
            // 
            this.btAnagirisKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAnagirisKapat.BackgroundImage")));
            this.btAnagirisKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAnagirisKapat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAnagirisKapat.FlatAppearance.BorderSize = 0;
            this.btAnagirisKapat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btAnagirisKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btAnagirisKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnagirisKapat.Location = new System.Drawing.Point(885, 3);
            this.btAnagirisKapat.Name = "btAnagirisKapat";
            this.btAnagirisKapat.Size = new System.Drawing.Size(38, 38);
            this.btAnagirisKapat.TabIndex = 3;
            this.btAnagirisKapat.UseVisualStyleBackColor = true;
            this.btAnagirisKapat.Click += new System.EventHandler(this.btAnagirisKapat_Click);
            // 
            // adminResim
            // 
            this.adminResim.Image = ((System.Drawing.Image)(resources.GetObject("adminResim.Image")));
            this.adminResim.Location = new System.Drawing.Point(686, 195);
            this.adminResim.Name = "adminResim";
            this.adminResim.Size = new System.Drawing.Size(120, 122);
            this.adminResim.TabIndex = 2;
            this.adminResim.TabStop = false;
            // 
            // akademisyenResim
            // 
            this.akademisyenResim.Image = ((System.Drawing.Image)(resources.GetObject("akademisyenResim.Image")));
            this.akademisyenResim.Location = new System.Drawing.Point(408, 198);
            this.akademisyenResim.Name = "akademisyenResim";
            this.akademisyenResim.Size = new System.Drawing.Size(120, 120);
            this.akademisyenResim.TabIndex = 1;
            this.akademisyenResim.TabStop = false;
            // 
            // ogrResim
            // 
            this.ogrResim.Image = ((System.Drawing.Image)(resources.GetObject("ogrResim.Image")));
            this.ogrResim.Location = new System.Drawing.Point(122, 196);
            this.ogrResim.Name = "ogrResim";
            this.ogrResim.Size = new System.Drawing.Size(120, 122);
            this.ogrResim.TabIndex = 0;
            this.ogrResim.TabStop = false;
            // 
            // AnaGirisPanelAlt
            // 
            this.AnaGirisPanelAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.AnaGirisPanelAlt.Controls.Add(this.ogrenciGiris);
            this.AnaGirisPanelAlt.Controls.Add(this.akademisyenGirisi);
            this.AnaGirisPanelAlt.Controls.Add(this.adminGiris);
            this.AnaGirisPanelAlt.Location = new System.Drawing.Point(142, 365);
            this.AnaGirisPanelAlt.Name = "AnaGirisPanelAlt";
            this.AnaGirisPanelAlt.Size = new System.Drawing.Size(925, 240);
            this.AnaGirisPanelAlt.TabIndex = 6;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // AnaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 645);
            this.Controls.Add(this.AnaGirisPanelüst);
            this.Controls.Add(this.AnaGirisPanelAlt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaGiris";
            this.Text = "AnaGiris";
            this.AnaGirisPanelüst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akademisyenResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrResim)).EndInit();
            this.AnaGirisPanelAlt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ogrenciGiris;
        private System.Windows.Forms.Button akademisyenGirisi;
        private System.Windows.Forms.Button adminGiris;
        private System.Windows.Forms.Panel AnaGirisPanelüst;
        private System.Windows.Forms.Button btAnagirisKapat;
        private System.Windows.Forms.PictureBox adminResim;
        private System.Windows.Forms.PictureBox akademisyenResim;
        private System.Windows.Forms.PictureBox ogrResim;
        private System.Windows.Forms.Panel AnaGirisPanelAlt;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}