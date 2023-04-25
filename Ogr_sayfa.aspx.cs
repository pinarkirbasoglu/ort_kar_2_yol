using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;

namespace Ort_kar_2
{
    public partial class Ogr_sayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Ogrenci[] ogrenciler = new Ogrenci[2];
            for(int i = 0; i < ogrenciler.Length;i++)
            {
                Ogrenci ogrencim = new Ogrenci();
                ogrencim.Isim = Interaction.InputBox((i + 1) + ".öğrencinin ismini giriniz:");
                for(int j = 0;j<3;j++)
                {
                    ogrencim.Notlar[j] = Convert.ToInt32(Interaction.InputBox((i + 1) + ". öğrencinin" + " " + (j + 1) + ". notunu giriniz:"));
                }
                //ogrenciler[i].Notlar = ogrencim.Notlar;
                ogrencim.ort_hesapla();
                ogrenciler[i] = ogrencim;
            }
            double ebo = ogrenciler[0].Ortalma;
            double eko = ogrenciler[0].Ortalma;
            int ebi = 0;
            int eki = 0;
            for(int i = 0; i < ogrenciler.Length;i++)
            {
                if (ebo < ogrenciler[i].Ortalma) ebi = i;
                if (eko > ogrenciler[i].Ortalma) eki = i;
            }
            string sonuc = ogrenciler[ebi].Isim + "li öğrenci" + " " + ogrenciler[ebi].Ortalma + " ortalma ile daha başarılıdır."
                + ogrenciler[eki].Isim + " isimli " + " " + ogrenciler[eki].Ortalma + " ortalamsına sahip olan öğrenciye göre";
            Response.Write(sonuc);
        }
    }
}