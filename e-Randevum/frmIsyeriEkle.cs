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
    public partial class frmIsyeriEkle : Form
    {
        public frmIsyeriEkle()
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

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void btnIsyeriEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                Adres adres = new Adres();
                adres.Il = txtIl.Text;
                adres.Ilce = txtIlce.Text;
                adres.Sokak = txtSokak.Text;
                adres.KapiNo = Convert.ToInt32(txtKapiNo.Text);
                adres.DaireNo = Convert.ToInt32(txtDaireNo.Text);
                adres.Ekle();
                adres.Sorgula();

                Yetkili yetkili = new Yetkili();
                yetkili.isim = txtIsim.Text;
                yetkili.soyisim = txtSoyad.Text;
                yetkili.Ekle();
                yetkili.Sorgula();

                Isyeri ısyeri = new Isyeri();
                ısyeri.Adres = adres.AdresID;
                ısyeri.Yetkili = yetkili.YetkiliId;
                ısyeri.IsyeriAd = txtIsyeriAd.Text;
                ısyeri.Kategori = 2;
                ısyeri.Telefon = txtTelefon.Text;
                ısyeri.Ekle();
                ısyeri.Sorgula();
                yetkili.IsyeriId = ısyeri.IsyeriID;
                yetkili.Guncelle();
                MessageBox.Show("İşyeri Eklendi.");

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
