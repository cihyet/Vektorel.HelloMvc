using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vektorel.EfApp
{
    class OkulContext:DbContext
    {
        public OkulContext()
        {

        }
        public DbSet<Ogrenci> Ogrenciler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Integrated Security=true;Initial Catalog=OkulDbEf");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {//Fluent Api
            modelBuilder.Entity<Ogrenci>().ToTable("tblOgrenciler");
            modelBuilder.Entity<Ogrenci>().Property(o => o.Ad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ogrenci>().Property(o => o.Soyad).HasColumnType("varchar").HasMaxLength(50).IsRequired();
        }
    }
}
