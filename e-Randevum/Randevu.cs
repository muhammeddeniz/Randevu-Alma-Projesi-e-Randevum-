using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace e_Randevum1
{
   public class Randevu:IRaporlayabilen
    {
        public int RAndevuId { get; set; }
        public int IsyeriID { get; set; }
        public int KullaniciID { get; set; }
        public string RandevuSaat { get; set; }
        public string RandevuTarih { get; set; }
        public Boolean RandevuOnay { get; set; }

        SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = eRandevum; Integrated Security = True; User Id = deniz; password=deniz");
        SqlCommand cmd;
        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        DataTable dataTable = new DataTable();
        public DataTable Raporla()
        {
            connection.Open();
            DataAdapter = new SqlDataAdapter("select *from RandevuBilgisi", connection);
            DataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
    }
}
