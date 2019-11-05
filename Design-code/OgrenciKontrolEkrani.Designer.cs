namespace Staj_Takip_Sistemi
{
    partial class OgrenciKontrolEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciKontrolEkrani));
            this.btDelete = new System.Windows.Forms.Button();
            this.btDuzenle = new System.Windows.Forms.Button();
            this.aramaButon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbOgrNoAra = new System.Windows.Forms.TextBox();
            this.btGeriOgrArama = new System.Windows.Forms.Button();
            this.btKapatOgrArama = new System.Windows.Forms.Button();
            this.btYeniOgrKaydet = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDelete.BackgroundImage")));
            this.btDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Location = new System.Drawing.Point(193, 432);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(53, 53);
            this.btDelete.TabIndex = 18;
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btDuzenle
            // 
            this.btDuzenle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDuzenle.BackgroundImage")));
            this.btDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDuzenle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDuzenle.Location = new System.Drawing.Point(57, 432);
            this.btDuzenle.Name = "btDuzenle";
            this.btDuzenle.Size = new System.Drawing.Size(53, 53);
            this.btDuzenle.TabIndex = 17;
            this.btDuzenle.UseVisualStyleBackColor = true;
            this.btDuzenle.Click += new System.EventHandler(this.btDuzenle_Click);
            // 
            // aramaButon
            // 
            this.aramaButon.BackColor = System.Drawing.Color.White;
            this.aramaButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aramaButon.BackgroundImage")));
            this.aramaButon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.aramaButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aramaButon.Location = new System.Drawing.Point(329, 46);
            this.aramaButon.Name = "aramaButon";
            this.aramaButon.Size = new System.Drawing.Size(53, 53);
            this.aramaButon.TabIndex = 16;
            this.aramaButon.UseVisualStyleBackColor = false;
            this.aramaButon.Click += new System.EventHandler(this.aramaButon_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tbOgrNoAra);
            this.panel2.Location = new System.Drawing.Point(57, 46);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(269, 53);
            this.panel2.TabIndex = 15;
            // 
            // tbOgrNoAra
            // 
            this.tbOgrNoAra.BackColor = System.Drawing.Color.White;
            this.tbOgrNoAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOgrNoAra.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbOgrNoAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbOgrNoAra.Location = new System.Drawing.Point(7, 13);
            this.tbOgrNoAra.Margin = new System.Windows.Forms.Padding(4);
            this.tbOgrNoAra.Name = "tbOgrNoAra";
            this.tbOgrNoAra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbOgrNoAra.Size = new System.Drawing.Size(258, 26);
            this.tbOgrNoAra.TabIndex = 3;
            this.tbOgrNoAra.Text = "Ögrenci No";
            this.tbOgrNoAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btGeriOgrArama
            // 
            this.btGeriOgrArama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btGeriOgrArama.BackgroundImage")));
            this.btGeriOgrArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btGeriOgrArama.Cursor = System.Windows.Forms.Cursors.Default;
            this.btGeriOgrArama.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btGeriOgrArama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGeriOgrArama.Location = new System.Drawing.Point(390, 1);
            this.btGeriOgrArama.Name = "btGeriOgrArama";
            this.btGeriOgrArama.Size = new System.Drawing.Size(30, 28);
            this.btGeriOgrArama.TabIndex = 43;
            this.btGeriOgrArama.UseVisualStyleBackColor = true;
            this.btGeriOgrArama.Click += new System.EventHandler(this.btGeriOgrArama_Click);
            // 
            // btKapatOgrArama
            // 
            this.btKapatOgrArama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btKapatOgrArama.BackgroundImage")));
            this.btKapatOgrArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btKapatOgrArama.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btKapatOgrArama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKapatOgrArama.Location = new System.Drawing.Point(419, 1);
            this.btKapatOgrArama.Name = "btKapatOgrArama";
            this.btKapatOgrArama.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btKapatOgrArama.Size = new System.Drawing.Size(28, 28);
            this.btKapatOgrArama.TabIndex = 42;
            this.btKapatOgrArama.UseVisualStyleBackColor = true;
            this.btKapatOgrArama.Click += new System.EventHandler(this.btKapatOgrArama_Click);
            // 
            // btYeniOgrKaydet
            // 
            this.btYeniOgrKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btYeniOgrKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btYeniOgrKaydet.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btYeniOgrKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btYeniOgrKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btYeniOgrKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btYeniOgrKaydet.Image")));
            this.btYeniOgrKaydet.Location = new System.Drawing.Point(347, 432);
            this.btYeniOgrKaydet.Name = "btYeniOgrKaydet";
            this.btYeniOgrKaydet.Size = new System.Drawing.Size(47, 47);
            this.btYeniOgrKaydet.TabIndex = 44;
            this.btYeniOgrKaydet.UseVisualStyleBackColor = false;
            // 
            // OgrenciKontrolEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(448, 494);
            this.Controls.Add(this.btYeniOgrKaydet);
            this.Controls.Add(this.btGeriOgrArama);
            this.Controls.Add(this.btKapatOgrArama);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btDuzenle);
            this.Controls.Add(this.aramaButon);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgrenciKontrolEkrani";
            this.Text = "OgrenciKontrolEkrani";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btDuzenle;
        private System.Windows.Forms.Button aramaButon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbOgrNoAra;
        private System.Windows.Forms.Button btGeriOgrArama;
        private System.Windows.Forms.Button btKapatOgrArama;
        private System.Windows.Forms.Button btYeniOgrKaydet;
    }
}