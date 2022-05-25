using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
    class Personel
    {
        public Veritabani.C_Personel_Table hesap_var_mi(string tc, string pass)
        {
            Veritabani.Project_DataEntities ent = new Veritabani.Project_DataEntities();
            var sonuc = ent.C_Personel_Table.Where(q => q.TC == tc && q.Sifre == pass);
            if (sonuc != null)
            {
                return sonuc.FirstOrDefault();
            }
            else return null;
        }
    }
}
