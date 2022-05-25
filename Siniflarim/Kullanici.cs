using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
    public class Kullanici
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string tcNo { get; set; }
        public string email { get; set; }
        public string yetki { get; set; }
        public string Menu { get; set; }

        Veritabani.Project_DataEntities ent = new Veritabani.Project_DataEntities();
        public string Veriekleme(Veritabani.Kullanici_Table nesne)
        {
            Veritabani.Kullanici_Table yeni = new Veritabani.Kullanici_Table();
            yeni = nesne;
            ent.Kullanici_Table.Add(yeni);
            int s = ent.SaveChanges();
            if (s == 1)
            {
                return "1";
            }
            else return "0";

        }
        public Veritabani.Kullanici_Table hesap_var_mi(string tc, string pass, string yetki)
        {
            var sonuc = ent.Kullanici_Table.Where(q => q.Kullanici_TC == tc && q.Kullanici_sifresi == pass && q.Kullanici_Yetki == yetki);
            if (sonuc != null)
            {
                return sonuc.FirstOrDefault();
            }
            else return null;
        }

        public List<Veritabani.Kullanici_Table> listele()
        {
            Veritabani.Project_DataEntities ent = new Veritabani.Project_DataEntities();
            var sonuc = ent.Kullanici_Table.ToList();
            return sonuc;
        }
        public string Sifre_goster(string tc, string email, string yetki)
        {

            var result = ent.Kullanici_Table.Where(x => x.Kullanici_TC == tc && x.Kullanici_email == email && x.Kullanici_Yetki == yetki).Select(x => x.Kullanici_sifresi).FirstOrDefault();
            if (result != null)
            {

                return result;
            }
            else
            {
                return null;
            }
        }
    }

}
