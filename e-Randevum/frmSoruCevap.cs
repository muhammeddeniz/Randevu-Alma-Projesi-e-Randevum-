﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Randevum1
{
    public partial class frmSoruCevap : Form
    {
        public frmSoruCevap()
        {
            InitializeComponent();
        }
        private int Move;
        private int Mouse_X;
        private int Mouse_Y;
        private void picBExit_Click(object sender, EventArgs e)
        {

            DialogResult cikis = new DialogResult();

            cikis = MessageBox.Show("Kapatmak İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }

        private void picBMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panelHeader_Move(object sender, EventArgs e)
        {
            Move = 0;
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void frmSoruCevap_Load(object sender, EventArgs e)
        {
            SoruCevap soruCevap = new SoruCevap();
            dGVIsyeri.DataSource = soruCevap.Raporla();
        }
    }
}
