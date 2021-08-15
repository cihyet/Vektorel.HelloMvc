using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vektorel.HelloMvc.Models
{
    public class OkulMvcContext:DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Integrated Security=true;Initial Catalog=OkulDbMvc");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ogrenci>().ToTable("tblOgrenciler");

            modelBuilder.Entity<Ogrenci>().Property(o => o.Ad).HasMaxLength(25).HasColumnType("varchar").IsRequired();

            modelBuilder.Entity<Ogrenci>().Property(o => o.Soyad).HasMaxLength(25).HasColumnType("varchar").IsRequired();
        }
    }
}
