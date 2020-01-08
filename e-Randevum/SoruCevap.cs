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
    class SoruCevap : IRaporlayabilen
    {
        public int SoruId { get; set; }
        public string SoruMetni { get; set; }
        public string CevapMetni { get; set; }

        SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = eRandevum; Integrated Security = True; User Id = deniz; password=deniz");
        SqlCommand cmd;
        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        DataTable dataTable = new DataTable();
        public DataTable Raporla()
        {
            connection.Open();
            DataAdapter = new SqlDataAdapter("select *from SoruVeCevaplar", connection);
            DataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
    }
}
