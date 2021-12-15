using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreProje.Models;

namespace AspNetCoreProje.Controllers
{
    public class DefaultController : Controller
    {
        //view component : Partial viewe benzer fakat view componentte controller olmadan modele erişim sağlar. .NETCore ile gelen özelliktir.
        
        /*View Start : Viewlerin başlangıç dosyası. Layoutları tek çatı altında toplar.
         * Controller tarafında her defasında ilgili layoutu seçmemize gerek kalmadan biizm için otonom bir şekilde layout seçip
         * viewleri çalıştıran core yapısıdır. View klasörü içine view start(razor görünümünden) eklenir. */
        
        /*Html Raw : String olarak verdiğimiz değişkenlerdeki html ifadelerini etkinleştirir.
         
        @{
         var Deger = "<b> Merhaba </b>";
          }
         @Html.Raw(Deger) şeklinde kullanılır.*/

        /*AspNetCore mvc ile mvc arasındaki fark, bootstrap, web dosyaları wwwroota eklenmeli.*/
        public IActionResult Index()
        {
            var ktp= new List<Kitaplar>()
            {
                new Kitaplar()
                { 
                ID=1, KitapAd="SATRANÇ", Yazar="STEFAN ZWEIG"
                },

                new Kitaplar()
                {
                    ID=2, KitapAd="BİLİNMEYEN BİR KADININ MEKTUBU", Yazar="STEFAN ZWEIG"
                },

                new Kitaplar()
                {
                    ID=3, KitapAd="BEN MALALA", Yazar="MALALA YUSUFZAY"
                }
            };
            return View(ktp);
        }

        public IActionResult StatikTema()
        {
            return View();
        }
    }
}
