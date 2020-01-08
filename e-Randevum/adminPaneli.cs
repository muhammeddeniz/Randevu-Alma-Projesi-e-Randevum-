using System;
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
    public partial class frmAdminPaneli : Form
    {
        public frmAdminPaneli()
        {
            InitializeComponent();
        }



        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmIsyeriEkle frmIsyeriEkle = new frmIsyeriEkle();
            frmIsyeriEkle.MdiParent = this;
            frmIsyeriEkle.Show();
        }

        private void ExitStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();

            cikis = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else { }
        }

        private void frmAdminPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cikis = new DialogResult();

            cikis = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);

            if (cikis == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (cikis == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void işyeriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsyeriSil frmIsyeriSil = new frmIsyeriSil();
            frmIsyeriSil.MdiParent = this;
            frmIsyeriSil.Show();
        }

        private void işyeriBulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsyeriBul frmIsyeriBul = new frmIsyeriBul();
            frmIsyeriBul.MdiParent = this;
            frmIsyeriBul.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmRandevuRapor frmRandevuRapor = new frmRandevuRapor();
            frmRandevuRapor.MdiParent = this;
            frmRandevuRapor.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmPersonelRapor frmPersonelRapor = new frmPersonelRapor();
            frmPersonelRapor.MdiParent = this;
            frmPersonelRapor.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmIsyeriRapor frmIsyeriRapor = new frmIsyeriRapor();
            frmIsyeriRapor.MdiParent = this;
            frmIsyeriRapor.Show();
        }

        private void yorumlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYorumlar frmYorumlar = new frmYorumlar();
            frmYorumlar.MdiParent = this;
            frmYorumlar.Show();
        }

        private void soruVeCevaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSoruCevap frmSoruCevap = new frmSoruCevap();
            frmSoruCevap.MdiParent = this;
            frmSoruCevap.Show();
        }
    }
}
