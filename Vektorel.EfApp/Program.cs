using Microsoft.EntityFrameworkCore;
using System;

namespace Vektorel.EfApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var ogr = new Ogrenci { Ad = "Ali", Soyad = "Veli", Numara = 456 };


            //ctx.Ogrenciler.Add(ogr);
            //int sonuc = ctx.SaveChanges();
            //if (sonuc>0)
            //{
            //    Console.WriteLine("Ekleme Başarılı");
            //}

            //Ogrenci ogr = ctx.Ogrenciler.Find(3);
            //ogr.Numara = 789;
            //ctx.Entry(ogr).State = EntityState.Modified;            
            //ctx.SaveChanges();


            using (OkulContext ctx = new OkulContext())
            {
                foreach (var item in ctx.Ogrenciler)
                {
                    Console.WriteLine(item.Ad);
                }
            }
        }
    }
}
//Entity Framework
//CRUD işlemlerinde kullanılır
//Bağlantı detaylarıyla uğraşmadan bu işlemleri yapabilmek
//DbContext classı: Veri işlemlerinin yapılmasından sorumlu class
//DbSet<> : Verilerin bellekte tutulmasından sorumlu tablolar
//Kullanıcıdan alınan bilgiler-> DbSet<Ogrenci> -> SaveChanges() -> Db
//Db First: Önce Database sonra kod
//Code First: Önce kod, sonra database