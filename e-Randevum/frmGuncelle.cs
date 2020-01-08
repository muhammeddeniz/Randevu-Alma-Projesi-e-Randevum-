using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace e_Randevum1
{
    public partial class frmGuncelle : Form
    {
        public frmGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source = TUNAYTOKSOZ\SQLEXPRESS; Initial Catalog = eRandevum; Integrated Security = True");
        SqlCommand cmd;
        SqlDataReader DataReader;
        public int Numara { get; set; }
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

        private void frmGuncelle_Load(object sender, EventArgs e)
        {
            connection.Open();
            cmd = new SqlCommand("Select * From IsyeriBilgisi Where IsYeriId = @Id", connection);
            cmd.Parameters.AddWithValue("@Id", Numara);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtIsyeriAd.Text = dr[1].ToString();
                txtIl.Text = dr[2].ToString();
                cmbBKategori.SelectedIndex = 0;
                txtIlce.Text = dr[3].ToString();
                txtTelefon.Text = dr[4].ToString();
                txtIsim.Text = dr[5].ToString();
                txtSoyad.Text = dr[6].ToString();
                txtSokak.Text = dr[7].ToString();
                txtKapiNo.Text = dr[8].ToString();
                txtDaireNo.Text = dr[9].ToString();
            }
        }

        private void btnIsyeriGuncelle_Click(object sender, EventArgs e)
        {
            Isyeri ısyeri = new Isyeri();
            ısyeri.IsyeriAd = txtIsyeriAd.Text;
            ısyeri.Kategori = Convert.ToInt32(cmbBKategori.SelectedIndex);
            ısyeri.Telefon = txtTelefon.Text;
            ısyeri.IsyeriID = Numara;

            Adres adres = new Adres();
            adres.numara = Numara;
            adres.Il = txtIl.Text;
            adres.Ilce = txtIlce.Text;
            adres.Sokak = txtSokak.Text;
            adres.KapiNo = Convert.ToInt32(txtKapiNo.Text);
            adres.DaireNo = Convert.ToInt32(txtDaireNo.Text);

            Yetkili yetkili = new Yetkili();
            yetkili.isim = txtIsim.Text;
            yetkili.soyisim = txtSoyad.Text;
            yetkili.IsyeriId = Numara;

            yetkili.IsımGuncelle();
            adres.Guncelle();
            ısyeri.Guncelle();
            MessageBox.Show("Güncelleme Başarılı.");
            
        }
    }
}
