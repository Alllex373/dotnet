using Sweet_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sweet_Shop.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult List()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    groupId = "1",
                    Name = "Banana",
                    Price ="55.5"
                },
                new Product
                {
                     Id = 2,
                    groupId = "2",
                    Name = "Kiwi",
                    Price ="75.5"
                }

            };

            return View(products);
        }

        public ActionResult Update(int? id)
        {
            if (!id.HasValue)
                return RedirectToAction("List");

            var product = new Product
            {
                Id = id.Value,
                groupId = "?",
                Name = "?",
                Price = "?"
            };
            return View(product);


        }

        [HttpPost]
        public ActionResult Update(Product model)
        {
            //if (!ModelState.IsValid)
            //    return View(model);

            return Redirect($"http://wwww.facebook.com");
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product model)
        {
            if (!ModelState.IsValid)
                return View(model);

            return Redirect($"http://wwww.facebook.com");
        }
    }
}