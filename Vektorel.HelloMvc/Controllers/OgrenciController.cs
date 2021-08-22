using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vektorel.HelloMvc.Models;

namespace Vektorel.HelloMvc.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()//Action
        {
            return View();
        }

        public IActionResult OgrenciListesi()
        {
            IEnumerable<Ogrenci> lst;
            using (var ctx = new OkulMvcContext())
            {
                lst = ctx.Ogrenciler.ToList();
            }           
            return View(lst);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult OgrenciEkle(Ogrenci ogr)
        {
            using (OkulMvcContext ctx = new OkulMvcContext())
            {
                ctx.Ogrenciler.Add(ogr);
                ctx.SaveChanges();
            }
            return View();
        }



        //Ogrenci/OgrenciEkle
        [HttpGet]
        public IActionResult OgrenciEkle() => View();



    }
}
