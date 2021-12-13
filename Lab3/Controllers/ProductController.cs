using Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            return View(Storage.Products);
        }

        public IActionResult Details(int id)
        {
            return View(Storage.Products.FirstOrDefault(x => x.Id == id));
        }
    }
}
