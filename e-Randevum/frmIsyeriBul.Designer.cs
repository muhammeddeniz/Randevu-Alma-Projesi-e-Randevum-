namespace e_Randevum1
{
    partial class frmIsyeriBul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIsyeriBul));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnTumunuListele = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.dGVBul = new System.Windows.Forms.DataGridView();
            this.txtBul = new System.Windows.Forms.TextBox();
            this.picBExit = new System.Windows.Forms.PictureBox();
            this.picBMinimize = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.btnTumunuListele);
            this.panel1.Controls.Add(this.btnBul);
            this.panel1.Controls.Add(this.dGVBul);
            this.panel1.Controls.Add(this.txtBul);
            this.panel1.Location = new System.Drawing.Point(6, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 417);
            this.panel1.TabIndex = 38;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(686, 6);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(101, 23);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(565, 6);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(101, 23);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnTumunuListele
            // 
            this.btnTumunuListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumunuListele.Location = new System.Drawing.Point(433, 6);
            this.btnTumunuListele.Name = "btnTumunuListele";
            this.btnTumunuListele.Size = new System.Drawing.Size(115, 23);
            this.btnTumunuListele.TabIndex = 9;
            this.btnTumunuListele.Text = "Tümünü Listele";
            this.btnTumunuListele.UseVisualStyleBackColor = true;
            this.btnTumunuListele.Click += new System.EventHandler(this.btnTumunuListele_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(314, 6);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(101, 23);
            this.btnBul.TabIndex = 8;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // dGVBul
            // 
            this.dGVBul.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dGVBul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBul.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dGVBul.Location = new System.Drawing.Point(-1, 34);
            this.dGVBul.MultiSelect = false;
            this.dGVBul.Name = "dGVBul";
            this.dGVBul.Size = new System.Drawing.Size(826, 380);
            this.dGVBul.TabIndex = 7;
            // 
            // txtBul
            // 
            this.txtBul.Location = new System.Drawing.Point(13, 8);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(280, 20);
            this.txtBul.TabIndex = 6;
            // 
            // picBExit
            // 
            this.picBExit.Image = ((System.Drawing.Image)(resources.GetObject("picBExit.Image")));
            this.picBExit.Location = new System.Drawing.Point(805, 15);
            this.picBExit.Name = "picBExit";
            this.picBExit.Size = new System.Drawing.Size(32, 32);
            this.picBExit.TabIndex = 40;
            this.picBExit.TabStop = false;
            this.picBExit.Click += new System.EventHandler(this.picBExit_Click);
            // 
            // picBMinimize
            // 
            this.picBMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picBMinimize.Image")));
            this.picBMinimize.Location = new System.Drawing.Point(766, 15);
            this.picBMinimize.Name = "picBMinimize";
            this.picBMinimize.Size = new System.Drawing.Size(32, 32);
            this.picBMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBMinimize.TabIndex = 41;
            this.picBMinimize.TabStop = false;
            this.picBMinimize.Click += new System.EventHandler(this.picBMinimize_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Location = new System.Drawing.Point(5, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(754, 50);
            this.panelHeader.TabIndex = 39;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            this.panelHeader.Move += new System.EventHandler(this.panelHeader_Move);
            // 
            // frmIsyeriBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBExit);
            this.Controls.Add(this.picBMinimize);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIsyeriBul";
            this.Text = "frmIsyeriGuncelle";
            this.Load += new System.EventHandler(this.frmIsyeriGuncelle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnTumunuListele;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.DataGridView dGVBul;
        private System.Windows.Forms.TextBox txtBul;
        private System.Windows.Forms.PictureBox picBExit;
        private System.Windows.Forms.PictureBox picBMinimize;
        private System.Windows.Forms.Panel panelHeader;
    }
}