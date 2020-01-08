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
    public partial class frmIsyeriBul : Form
    {
        public frmIsyeriBul()
        {
            InitializeComponent();
        }
        public int Numara;
        private int Move;
        private int Mouse_X;
        private int Mouse_Y;
        private void frmIsyeriGuncelle_Load(object sender, EventArgs e)
        {
            Isyeri ısyeri = new Isyeri();
           
                dGVBul.DataSource = ısyeri.Listele();
           
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Isyeri ısyeri = new Isyeri();
            ısyeri.DataTableClear();
            try
            {
                dGVBul.DataSource = ısyeri.Bul(txtBul.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            Isyeri ısyeri = new Isyeri();
            
                dGVBul.DataSource = ısyeri.Listele();
           
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Isyeri ısyeri = new Isyeri();
            ısyeri.DataTableClear();
        }

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

        private void panelHeader_Move(object sender, EventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Numara = Convert.ToInt32(dGVBul.CurrentRow.Cells["IsYeriId"].Value);

            frmGuncelle frmGuncelle = new frmGuncelle();
            frmGuncelle.Numara = Numara;
            frmGuncelle.Show();
        }
    }
}
