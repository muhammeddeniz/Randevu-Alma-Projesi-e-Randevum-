namespace e_Randevum1
{
    partial class frmSoruCevap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoruCevap));
            this.picBExit = new System.Windows.Forms.PictureBox();
            this.picBMinimize = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.dGVIsyeri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picBExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVIsyeri)).BeginInit();
            this.SuspendLayout();
            // 
            // picBExit
            // 
            this.picBExit.Image = ((System.Drawing.Image)(resources.GetObject("picBExit.Image")));
            this.picBExit.Location = new System.Drawing.Point(767, 5);
            this.picBExit.Name = "picBExit";
            this.picBExit.Size = new System.Drawing.Size(32, 32);
            this.picBExit.TabIndex = 56;
            this.picBExit.TabStop = false;
            this.picBExit.Click += new System.EventHandler(this.picBExit_Click);
            // 
            // picBMinimize
            // 
            this.picBMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picBMinimize.Image")));
            this.picBMinimize.Location = new System.Drawing.Point(729, 5);
            this.picBMinimize.Name = "picBMinimize";
            this.picBMinimize.Size = new System.Drawing.Size(32, 32);
            this.picBMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBMinimize.TabIndex = 57;
            this.picBMinimize.TabStop = false;
            this.picBMinimize.Click += new System.EventHandler(this.picBMinimize_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Location = new System.Drawing.Point(0, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(726, 52);
            this.panelHeader.TabIndex = 55;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.Move += new System.EventHandler(this.panelHeader_Move);
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.OrangeRed;
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.ForeColor = System.Drawing.SystemColors.Info;
            this.btnYazdir.Location = new System.Drawing.Point(627, 383);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(134, 63);
            this.btnYazdir.TabIndex = 54;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // dGVIsyeri
            // 
            this.dGVIsyeri.AllowUserToOrderColumns = true;
            this.dGVIsyeri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVIsyeri.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dGVIsyeri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVIsyeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVIsyeri.Location = new System.Drawing.Point(-2, 63);
            this.dGVIsyeri.Name = "dGVIsyeri";
            this.dGVIsyeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVIsyeri.Size = new System.Drawing.Size(804, 314);
            this.dGVIsyeri.TabIndex = 53;
            // 
            // frmSoruCevap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBExit);
            this.Controls.Add(this.picBMinimize);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.dGVIsyeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSoruCevap";
            this.Text = "frmSoruCevap";
            this.Load += new System.EventHandler(this.frmSoruCevap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVIsyeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBExit;
        private System.Windows.Forms.PictureBox picBMinimize;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.DataGridView dGVIsyeri;
    }
}