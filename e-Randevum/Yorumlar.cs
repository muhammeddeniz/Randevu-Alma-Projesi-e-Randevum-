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
    public class Yorumlar:IRaporlayabilen
    {
        public int YorumID { get; set; }
        public string YorumMetni { get; set; }
        SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = eRandevum; Integrated Security = True; User Id = deniz; password=deniz");
        SqlCommand cmd;
        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        DataTable dataTable = new DataTable();
        public DataTable Raporla()
        {
            connection.Open();
            DataAdapter = new SqlDataAdapter("select *from YorumBilgileri", connection);
            DataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
    }
}
