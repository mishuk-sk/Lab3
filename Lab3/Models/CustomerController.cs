using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class CustomerController : Controller
    {
        public IActionResult Add(int id )
        {
            return View(Storage.Products.FirstOrDefault(x => x.Id == id));
        }
    }
}
