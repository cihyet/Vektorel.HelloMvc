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
            lst.Add(new Ogrenci { Ad = "Ahmet", Soyad = "Mehmet", Numara = 123 });
            lst.Add(new Ogrenci { Ad = "Ali", Soyad = "Veli", Numara = 345 });
            lst.Add(new Ogrenci { Ad = "Osman", Soyad = "Yılmaz", Numara = 789 });

            //ViewData["liste"] = lst;
            //ViewBag.liste = lst;   
            //return View("OgrenciListesi",lst);
            return View(lst);
        }

        
    }
}
