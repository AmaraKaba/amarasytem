using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veritabani;


namespace Siniflarim
{
    public class Vatandaslar
    {

        public string VerEkleme(Veritabani.Cocuk_Table nesne)
        {
            Veritabani.Project_DataEntities ekle = new Veritabani.Project_DataEntities();
            Veritabani.Cocuk_Table yeni = new Veritabani.Cocuk_Table();
            yeni = nesne;
            ekle.Cocuk_Table.Add(yeni);
            int b = ekle.SaveChanges();
            if (b == 1)
            {
                return "1";
            }
            else
                return "0";
        }
        public string VerGuncelle(string ad, Veritabani.Cocuk_Table nesne)
        {
            Veritabani.Project_DataEntities Guncelleme = new Veritabani.Project_DataEntities();
            Veritabani.Cocuk_Table yeni = new Veritabani.Cocuk_Table();
            var aranan = Guncelleme.Cocuk_Table.Where(g => g.Ad == ad).ToList().FirstOrDefault();
            aranan = nesne;
            Guncelleme.SaveChanges();

            return "1";
        }

        public string VerSilme(string ad, Veritabani.Cocuk_Table nesne)
        {
            Veritabani.Project_DataEntities silme = new Veritabani.Project_DataEntities();
            Veritabani.Cocuk_Table yeni = new Veritabani.Cocuk_Table();
            var aranan = silme.Cocuk_Table.Where(b => b.Ad == ad).FirstOrDefault();
            silme.Cocuk_Table.Remove(yeni);
            silme.SaveChanges();

            return "1";
        }
        public string Hesap_var_mi(string ad, string pass)
        {
            Veritabani.Project_DataEntities ent = new Veritabani.Project_DataEntities();
            var sonuc = ent.Cocuk_Table.FirstOrDefault(x => x.Ad.Contains(ad) && x.Sifre.Contains(pass));
            if (sonuc != null)
            {
                return "1";
            }
            else
                return null;

        }



    }
}
