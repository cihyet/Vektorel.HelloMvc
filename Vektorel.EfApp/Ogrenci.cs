using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Vektorel.EfApp
{
    class Ogrenci
    {
        public int Ogrenciid { get; set; }
      
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Numara { get; set; }
    }
}
