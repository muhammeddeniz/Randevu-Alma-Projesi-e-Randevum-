using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace e_Randevum1
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = eRandevum; Integrated Security = True; User Id = deniz; password=deniz");
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select *From Admin where AdminId ='" + txtAdminId.Text + "'AND Sifre='" + txtSifre.Text + "'", connection);
            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                frmAdminPaneli adminPaneli = new frmAdminPaneli();
                adminPaneli.Show();
                this.Hide();
            }
            else
            {
                lblInfo.Text = "Hatalı Giriş Yaptınız" + Environment.NewLine + "Lütfen Yeniden Deneyin";
            }
            connection.Close();
        }
    }
}
