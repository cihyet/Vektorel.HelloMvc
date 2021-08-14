using System;

namespace Vektorel.EfApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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