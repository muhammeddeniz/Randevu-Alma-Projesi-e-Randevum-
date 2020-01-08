using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace e_Randevum1
{
    interface IRaporlayabilen
    {
        DataTable Raporla();
    }
}
