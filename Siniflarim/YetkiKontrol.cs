using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
    public enum yetki
    {
        Personel = 1,
        Vatandas = 2,
    }
    public class YetkiKontrol : System.Web.UI.Page
    {
        protected override void OnPreLoad(EventArgs e)
        {
            var yetki = (Veritabani.Kullanici_Table)System.Web.HttpContext.Current.Session["Kullanici"];
            if (yetki.Kullanici_Yetki !="Personel")
            {
                Response.Redirect("/Register.aspx");
            }
            base.OnPreLoad(e);
        }


    }
}
