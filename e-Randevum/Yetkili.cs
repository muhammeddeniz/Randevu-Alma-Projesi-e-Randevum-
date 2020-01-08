using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace e_Randevum1
{
    public class Yetkili:Kisi,IEkleyebilen,ISorgulayabilen,IRaporlayabilen
    {
        public int YetkiliId { get; set; }
        public string DogumTarihi { get; set; }
        public string TCKimlikNo { get; set; }
        public int IsyeriId { get; set; }
        public Boolean YetkiOnay { get; set; }

        SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = eRandevum; Integrated Security = True; User Id = deniz; password=deniz");
        SqlCommand cmd;
        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        DataTable dataTable = new DataTable();
        string sorgu = "INSERT INTO Yetkili(Isim,Soyisim) values (@isim,@soyisim)";
        public void Ekle()
        {
            cmd = new SqlCommand(sorgu, connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@isim", isim);
            cmd.Parameters.AddWithValue("@soyisim", soyisim);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void Guncelle()
        {
            string guncel = "UPDATE Yetkili SET IsYeriId = @ısyeri WHERE YetkiliId = @yetkiliId";
            cmd = new SqlCommand(guncel, connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@ısyeri", IsyeriId);
            cmd.Parameters.AddWithValue("@yetkiliId", YetkiliId);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void IsımGuncelle()
        {
            string guncel = "UPDATE Yetkili SET Isim = @Isim,Soyisim=@Soyisim WHERE IsYeriId = @IsyeriId";
            cmd = new SqlCommand(guncel, connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@Isim", isim);
            cmd.Parameters.AddWithValue("@Soyisim", soyisim);
            cmd.Parameters.AddWithValue("@IsYeriId", IsyeriId);
            cmd.ExecuteNonQuery();
            connection.Close();

        }
        public void Sorgula()
        {
            string Yetkili = "Select MAX(YetkiliId) AS max from Yetkili";
            cmd = new SqlCommand(Yetkili, connection);
            connection.Open();
            DataReader = cmd.ExecuteReader();
            if (DataReader.Read())
            {
                YetkiliId = Convert.ToInt32(DataReader["max"]);
            }
            DataReader.Close();
            connection.Close();
        }

        public DataTable Raporla()
        {
            connection.Open();
            DataAdapter = new SqlDataAdapter("select *from Yetkili", connection);
            DataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
    }
}
