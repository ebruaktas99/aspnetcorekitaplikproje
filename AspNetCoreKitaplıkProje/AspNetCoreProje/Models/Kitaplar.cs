using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreProje.Models
{
    public class Kitaplar
    {
        [Key]
        public int ID { get; set; }
        public string KitapAd { get; set; }
        public string Yazar { get; set; }
    }

}
