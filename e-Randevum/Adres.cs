using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace e_Randevum1
{
    public class Adres : IEkleyebilen, ISorgulayabilen
    {
        public int AdresID { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Sokak { get; set; }
        public int KapiNo { get; set; }
        public int DaireNo { get; set; }
        public int numara { get; set; }

        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        DataTable dataTable = new DataTable();
        SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = eRandevum; Integrated Security = True; User Id = deniz; password=deniz");
        SqlCommand cmd;
        string sorgu = "INSERT INTO IsYeriAdres(Il,Ilce,Sokak,KapiNo,DaireNo) values (@il,@ilce,@sokak,@kapiNo,@daireNo)";
        public void Ekle()
        {
            connection.Open();
            cmd = new SqlCommand(sorgu, connection);
            cmd.Parameters.AddWithValue("@il", Il);
            cmd.Parameters.AddWithValue("@ilce", Ilce);
            cmd.Parameters.AddWithValue("@sokak", Sokak);
            cmd.Parameters.AddWithValue("@kapiNo", KapiNo);
            cmd.Parameters.AddWithValue("@daireNo", DaireNo);
            cmd.ExecuteNonQuery();
            connection.Close();

        }
        public void Guncelle()
        {
            string sorgula = "SELECT AdresId From IsYeri Where IsYeriId = @IsYeriId";
            cmd = new SqlCommand(sorgula, connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@IsyeriId", numara);
            DataReader = cmd.ExecuteReader();
            if (DataReader.Read())
            {
                AdresID = Convert.ToInt32(DataReader["AdresId"]);
            }
            connection.Close();
            string guncel = "UPDATE IsYeriAdres SET Il = @Il,Ilce = @Il,Sokak = @Sokak,KapiNo = @KapiNo,DaireNo=@DaireNo WHERE AdresId = @AdresId";
            cmd = new SqlCommand(guncel, connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@AdresId", AdresID);
            cmd.Parameters.AddWithValue("@Il", Il);
            cmd.Parameters.AddWithValue("@Ilce", Ilce);
            cmd.Parameters.AddWithValue("@Sokak", Sokak);
            cmd.Parameters.AddWithValue("@KapiNo", KapiNo);
            cmd.Parameters.AddWithValue("@DaireNo", DaireNo);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Sorgula()
        {
            string adres = "Select MAX(AdresId) AS max from IsYeriAdres";
            cmd = new SqlCommand(adres, connection);
            connection.Open();
            DataReader = cmd.ExecuteReader();
            if (DataReader.Read())
            {
                AdresID = Convert.ToInt32(DataReader["max"]);
            }
            DataReader.Close();
            connection.Close();
        }
    }
}
