using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UdemyEfCore.Data.Contexts;
using UdemyEfCore.Data.Entities;
using UdemyEfCore.Models;

namespace UdemyEfCore.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            Context c = new();

            //EKLEME
            //var entityEntry = c.Products.Add(new Product()
            //{
            //    Name = "Telefon",
            //    Price = 3400
            //});

            //GÜNCELLEME

            //var productUpdate = c.Products.Find(1);
            //productUpdate.Price = 4000;
            //c.Products.Update(productUpdate);
            //c.SaveChanges();

            //SİLME
            //var productDelete = c.Products.FirstOrDefault(x => x.Id == 1);
            //c.Products.Remove(productDelete);
            //c.SaveChanges();
            
            return View();
        }

        
    }
}
