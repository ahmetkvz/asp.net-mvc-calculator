using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eskiyeniDeneme.Models
{
    public class calc
    {
        public double Sayi1 { get; set; }
        public double Sayi2 { get; set; }
        public string Islem { get; set; }
        public double Sonuc { get; set; }
       
        public int Id { get; set;  }
        public DateTime Timestamp { get; set; } = DateTime.Now;


    }
}