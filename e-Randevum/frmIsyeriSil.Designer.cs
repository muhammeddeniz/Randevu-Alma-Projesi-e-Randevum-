namespace e_Randevum1
{
    partial class frmIsyeriSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIsyeriSil));
            this.panelIsyeriSil = new System.Windows.Forms.Panel();
            this.picBExit = new System.Windows.Forms.PictureBox();
            this.picBMinimize = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblIsyeriSil = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.dGVIsyeriListe = new System.Windows.Forms.DataGridView();
            this.panelIsyeriSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimize)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVIsyeriListe)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIsyeriSil
            // 
            this.panelIsyeriSil.Controls.Add(this.picBExit);
            this.panelIsyeriSil.Controls.Add(this.picBMinimize);
            this.panelIsyeriSil.Controls.Add(this.panelHeader);
            this.panelIsyeriSil.Controls.Add(this.btnSil);
            this.panelIsyeriSil.Controls.Add(this.dGVIsyeriListe);
            this.panelIsyeriSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIsyeriSil.Location = new System.Drawing.Point(0, 0);
            this.panelIsyeriSil.Name = "panelIsyeriSil";
            this.panelIsyeriSil.Size = new System.Drawing.Size(800, 450);
            this.panelIsyeriSil.TabIndex = 1;
            // 
            // picBExit
            // 
            this.picBExit.Image = ((System.Drawing.Image)(resources.GetObject("picBExit.Image")));
            this.picBExit.Location = new System.Drawing.Point(767, 3);
            this.picBExit.Name = "picBExit";
            this.picBExit.Size = new System.Drawing.Size(32, 32);
            this.picBExit.TabIndex = 36;
            this.picBExit.TabStop = false;
            this.picBExit.Click += new System.EventHandler(this.picBExit_Click);
            // 
            // picBMinimize
            // 
            this.picBMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picBMinimize.Image")));
            this.picBMinimize.Location = new System.Drawing.Point(729, 3);
            this.picBMinimize.Name = "picBMinimize";
            this.picBMinimize.Size = new System.Drawing.Size(32, 32);
            this.picBMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBMinimize.TabIndex = 37;
            this.picBMinimize.TabStop = false;
            this.picBMinimize.Click += new System.EventHandler(this.picBMinimize_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblIsyeriSil);
            this.panelHeader.Location = new System.Drawing.Point(0, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(726, 52);
            this.panelHeader.TabIndex = 8;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // lblIsyeriSil
            // 
            this.lblIsyeriSil.BackColor = System.Drawing.Color.OrangeRed;
            this.lblIsyeriSil.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsyeriSil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblIsyeriSil.Location = new System.Drawing.Point(285, 6);
            this.lblIsyeriSil.Name = "lblIsyeriSil";
            this.lblIsyeriSil.Size = new System.Drawing.Size(216, 35);
            this.lblIsyeriSil.TabIndex = 0;
            this.lblIsyeriSil.Text = "İşyeri Sil";
            this.lblIsyeriSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSil.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSil.Location = new System.Drawing.Point(627, 381);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(134, 63);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dGVIsyeriListe
            // 
            this.dGVIsyeriListe.AllowUserToOrderColumns = true;
            this.dGVIsyeriListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVIsyeriListe.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dGVIsyeriListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVIsyeriListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVIsyeriListe.Location = new System.Drawing.Point(-2, 61);
            this.dGVIsyeriListe.Name = "dGVIsyeriListe";
            this.dGVIsyeriListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVIsyeriListe.Size = new System.Drawing.Size(804, 314);
            this.dGVIsyeriListe.TabIndex = 6;
            // 
            // frmIsyeriSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelIsyeriSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIsyeriSil";
            this.Text = "frmIsyeriSil";
            this.Load += new System.EventHandler(this.frmIsyeriSil_Load);
            this.panelIsyeriSil.ResumeLayout(false);
            this.panelIsyeriSil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimize)).EndInit();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVIsyeriListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIsyeriSil;
        private System.Windows.Forms.PictureBox picBExit;
        private System.Windows.Forms.PictureBox picBMinimize;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblIsyeriSil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dGVIsyeriListe;
    }
}