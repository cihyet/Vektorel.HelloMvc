using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            using (var ctx = new OkulMvcContext())
            {
                return View(ctx.Ogrenciler.ToList());
            }
        }


        //Cross Site Scripting Attck
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult OgrenciEkle(Ogrenci ogr)
        {
            using (OkulMvcContext ctx = new OkulMvcContext())
            {
                ctx.Ogrenciler.Add(ogr);
                int sonuc = ctx.SaveChanges();
                sonuc = 0;
                if (sonuc > 0)
                {
                    return RedirectToAction("OgrenciListesi");
                }
            }
            TempData["sonuc"] = 0;
            return View();
        }

        //Ogrenci/OgrenciEkle
        [HttpGet]
        public IActionResult OgrenciEkle() => View();


        public IActionResult OgrenciDetay(int? id)
        {
            using (var ctx = new OkulMvcContext())
            {
                var ogr = ctx.Ogrenciler.Find(id);
                return View(ogr);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult OgrenciDetay(Ogrenci ogr)
        {
            using (var ctx=new OkulMvcContext())
            {
                ctx.Entry(ogr).State = EntityState.Modified;
                ctx.SaveChanges();
                return RedirectToAction("OgrenciListesi");
            }
        }

        public IActionResult OgrenciSil(int? id)
        {
            using (var ctx=new OkulMvcContext())
            {
                ctx.Ogrenciler.Remove(ctx.Ogrenciler.Find(id));
                ctx.SaveChanges();
                return RedirectToAction("OgrenciListesi");
            }
        }
    }
}
