using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
    public class Menu
    {
        public List<Veritabani.BilgiEkle> GetByYetki(string yetki)
        {
            Veritabani.Project_DataEntities ent = new Veritabani.Project_DataEntities();
            var sonuc = ent.BilgiEkle.Where(q => q.Menu_yetki.Contains(yetki)).OrderBy(q => q.Menu_sira).ToList();
            return sonuc;
        }

      
    }
}
