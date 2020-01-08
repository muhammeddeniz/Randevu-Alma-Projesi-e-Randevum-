using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace e_Randevum1
{
    public class Isyeri:ISorgulayabilen,IEkleyebilen,IDuzenleyebilen,IRaporlayabilen
    {
        public int IsyeriID { get; set; }
        public string IsyeriAd { get; set; }
        public int Kategori { get; set; }
        public string Telefon { get; set; }
        public int Yetkili { get; set; }
        public int Adres { get; set; }

        SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = eRandevum; Integrated Security = True; User Id = deniz; password=deniz");
        SqlCommand cmd;
        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        DataTable dataTable = new DataTable();
        string sorgu = "INSERT INTO IsYeri(IsYeriAdi,KategoriId,YetkiliId,AdresId,Telefon) values (@Ad,@kategori,@yetkili,@adres,@Telefon)";

        public void Ekle()
        {
            cmd = new SqlCommand(sorgu, connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@Ad", IsyeriAd);
            cmd.Parameters.AddWithValue("@kategori", Kategori);
            cmd.Parameters.AddWithValue("@yetkili", Yetkili);
            cmd.Parameters.AddWithValue("@adres", Adres);
            cmd.Parameters.AddWithValue("@Telefon", Telefon);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Sorgula()
        {
            string Isyeri = "Select MAX(IsYeriId) AS max from IsYeri";
            cmd = new SqlCommand(Isyeri, connection);
            connection.Open();
            DataReader = cmd.ExecuteReader();
            if (DataReader.Read())
            {
              IsyeriID = Convert.ToInt32(DataReader["max"]);
            }
            DataReader.Close();
            connection.Close();
        }

        public void Guncelle()
        {
            string guncel = "UPDATE IsYeri SET IsYeriAdi = @IsyeriAdi,KategoriId = @Kategori,Telefon = @Telefon WHERE IsYeriId = @IsYeriId";
            cmd = new SqlCommand(guncel, connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@IsYeriId", IsyeriID);
            cmd.Parameters.AddWithValue("@IsYeriAdi",IsyeriAd);
            cmd.Parameters.AddWithValue("@Kategori", Kategori);
            cmd.Parameters.AddWithValue("@Telefon",Telefon);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Sil(int Id)
        {
            string sorgu = "DELETE FROM IsYeri WHERE IsYeriId = @isyeriId";
            cmd = new SqlCommand(sorgu, connection);
            cmd.Parameters.AddWithValue("isyeriId", Id);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable Bul(string kelime)
        {
            connection.Open();
            DataAdapter = new SqlDataAdapter("Select *from IsyeriBilgisi Where IsYeriAdi Like '%" + kelime + "%'", connection);
            DataAdapter.Fill(dataTable);
            connection.Close();

            return dataTable;
        }

        public DataTable Listele()
        {
            connection.Open();
            DataAdapter = new SqlDataAdapter("Select *from IsyeriBilgisi", connection);
            DataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        public void DataTableClear()
        {
            dataTable.Clear();
        }

        public DataTable Raporla()
        {
            connection.Open();
            DataAdapter = new SqlDataAdapter("select *from IsyeriRapor", connection);
            DataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
    }
}
