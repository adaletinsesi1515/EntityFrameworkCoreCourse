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
            Context c = new Context();

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

            //c.Employees.Add(new ParttimeEmployee
            //{
            //    DailyWage = 400,
            //    Firstname = "Memduh",
            //    Lastname = "Gümen"                
            //});

            //c.Employees.Add(new ParttimeEmployee
            //{
            //    DailyWage = 500,
            //    Firstname = "Memduh1",
            //    Lastname = "Gümen1"
            //});

            //c.Employees.Add(new FulltimeEmployee
            //{
            //    HourlyWage = 200,
            //    Firstname = "Hasan1",
            //    Lastname = "Hasan1"
            //});
            
            //c.Employees.Add(new FulltimeEmployee
            //{
            //    HourlyWage = 300,
            //    Firstname = "Hasan2",
            //    Lastname = "Hasan2"
            //});

            //c.SaveChanges();

            return View();
        }

        
    }
}
