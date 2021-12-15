using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; //viewcomponentte miras alsın diye
using AspNetCoreProje.Models;//listede kitaba ulaşabilmek için

namespace AspNetCoreProje.ViewComponents
{
    //view componenti oluşturduk. Index de istediğimiz yere ekleyebiliriz.
    public class YeniKitaplar:ViewComponent //unutma
    {
        public IViewComponentResult Invoke()
        {
            //yeni ekleyeceğimiz kitapların listesi

            var kitaplistesi = new List<Kitaplar>
            {
                new Kitaplar
                {
                    ID=6,KitapAd="Korku", Yazar="Stefan Zweig"
                },

                 new Kitaplar
                {
                    ID=7, KitapAd="Anna Karania", Yazar="Tolstoy"
                }
            };
            return View(kitaplistesi);
        }
    }
}
