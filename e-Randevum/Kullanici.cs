using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Randevum1
{
    public class Kullanici:Kisi
    {
        public int KullaniciId { get; set; }
        public string sonGirisSaati { get; set; }
        public int yetkiliId { get; set; }
    }
}
