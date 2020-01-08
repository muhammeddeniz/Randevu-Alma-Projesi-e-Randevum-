namespace e_Randevum1
{
    partial class frmAdminPaneli
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStripAdmin = new System.Windows.Forms.MenuStrip();
            this.işyeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.işyeriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işyeriBulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RaporHazirlaStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.işyeriYorumlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yorumlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soruVeCevaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HakkımızdaStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripAdmin
            // 
            this.MenuStripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işyeriToolStripMenuItem,
            this.RaporHazirlaStripMenuItem1,
            this.işyeriYorumlarToolStripMenuItem,
            this.HakkımızdaStripMenuItem3,
            this.ExitStripMenuItem2});
            this.MenuStripAdmin.Location = new System.Drawing.Point(0, 0);
            this.MenuStripAdmin.Name = "MenuStripAdmin";
            this.MenuStripAdmin.Size = new System.Drawing.Size(1511, 24);
            this.MenuStripAdmin.TabIndex = 0;
            this.MenuStripAdmin.Text = "menuStrip2";
            // 
            // işyeriToolStripMenuItem
            // 
            this.işyeriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.işyeriSilToolStripMenuItem,
            this.işyeriBulToolStripMenuItem});
            this.işyeriToolStripMenuItem.Name = "işyeriToolStripMenuItem";
            this.işyeriToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.işyeriToolStripMenuItem.Text = "İşyeri";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem4.Text = "İşyeri Ekle";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // işyeriSilToolStripMenuItem
            // 
            this.işyeriSilToolStripMenuItem.Name = "işyeriSilToolStripMenuItem";
            this.işyeriSilToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.işyeriSilToolStripMenuItem.Text = "İşyeri Sil";
            this.işyeriSilToolStripMenuItem.Click += new System.EventHandler(this.işyeriSilToolStripMenuItem_Click);
            // 
            // işyeriBulToolStripMenuItem
            // 
            this.işyeriBulToolStripMenuItem.Name = "işyeriBulToolStripMenuItem";
            this.işyeriBulToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.işyeriBulToolStripMenuItem.Text = "İşyeri Bul";
            this.işyeriBulToolStripMenuItem.Click += new System.EventHandler(this.işyeriBulToolStripMenuItem_Click);
            // 
            // RaporHazirlaStripMenuItem1
            // 
            this.RaporHazirlaStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.RaporHazirlaStripMenuItem1.Name = "RaporHazirlaStripMenuItem1";
            this.RaporHazirlaStripMenuItem1.Size = new System.Drawing.Size(89, 20);
            this.RaporHazirlaStripMenuItem1.Text = "Rapor Hazırla";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem6.Text = "Randevu Raporları";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem7.Text = "Personel Raporları";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem8.Text = "İşyeri Raporları";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // işyeriYorumlarToolStripMenuItem
            // 
            this.işyeriYorumlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yorumlarToolStripMenuItem,
            this.soruVeCevaplarToolStripMenuItem});
            this.işyeriYorumlarToolStripMenuItem.Name = "işyeriYorumlarToolStripMenuItem";
            this.işyeriYorumlarToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.işyeriYorumlarToolStripMenuItem.Text = "İşyeri Görüşleri";
            // 
            // yorumlarToolStripMenuItem
            // 
            this.yorumlarToolStripMenuItem.Name = "yorumlarToolStripMenuItem";
            this.yorumlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yorumlarToolStripMenuItem.Text = "Yorumlar";
            this.yorumlarToolStripMenuItem.Click += new System.EventHandler(this.yorumlarToolStripMenuItem_Click);
            // 
            // soruVeCevaplarToolStripMenuItem
            // 
            this.soruVeCevaplarToolStripMenuItem.Name = "soruVeCevaplarToolStripMenuItem";
            this.soruVeCevaplarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.soruVeCevaplarToolStripMenuItem.Text = "Soru ve Cevaplar";
            this.soruVeCevaplarToolStripMenuItem.Click += new System.EventHandler(this.soruVeCevaplarToolStripMenuItem_Click);
            // 
            // HakkımızdaStripMenuItem3
            // 
            this.HakkımızdaStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11});
            this.HakkımızdaStripMenuItem3.Name = "HakkımızdaStripMenuItem3";
            this.HakkımızdaStripMenuItem3.Size = new System.Drawing.Size(81, 20);
            this.HakkımızdaStripMenuItem3.Text = "Hakkımızda";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem11.Text = "Biz Kimiz?";
            // 
            // ExitStripMenuItem2
            // 
            this.ExitStripMenuItem2.Name = "ExitStripMenuItem2";
            this.ExitStripMenuItem2.Size = new System.Drawing.Size(44, 20);
            this.ExitStripMenuItem2.Text = "Çıkış";
            this.ExitStripMenuItem2.Click += new System.EventHandler(this.ExitStripMenuItem2_Click);
            // 
            // frmAdminPaneli
            // 
            this.ClientSize = new System.Drawing.Size(1511, 706);
            this.Controls.Add(this.MenuStripAdmin);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStripAdmin;
            this.Name = "frmAdminPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdminPaneli_FormClosing);
            this.MenuStripAdmin.ResumeLayout(false);
            this.MenuStripAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAnaSayfa;
        private System.Windows.Forms.Panel panelHosgeldiniz;
        private System.Windows.Forms.Label lblHosgeldiniz;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bizKimizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onaylanmışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onayBekleyenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yetkiliOnaylaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diğerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işYeriRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporHazırlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işyeriGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işYeriBulToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem işYeriSilToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem işYeriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işyeriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip MenuStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem işyeriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem işyeriSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işyeriBulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RaporHazirlaStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem işyeriYorumlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yorumlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soruVeCevaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HakkımızdaStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem ExitStripMenuItem2;
    }
}

