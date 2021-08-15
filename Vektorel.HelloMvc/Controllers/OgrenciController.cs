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
            var lst = new List<Ogrenci>();
            

            //ViewData["liste"] = lst;
            //ViewBag.liste = lst; 
            return View(lst);
        }


        [HttpPost]
        public IActionResult OgrenciEkle(Ogrenci ogr)
        {
            using (OkulMvcContext ctx=new OkulMvcContext())
            {             
                ctx.Ogrenciler.Add(ogr);
                ctx.SaveChanges();                
            }
            return View();
        }


        public IActionResult OgrenciEkle() => View();
       


    }
}
