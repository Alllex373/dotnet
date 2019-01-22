using Sweet_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sweet_Shop.Controllers
{
    public class GroupsController : Controller
    {
        // GET: Groups
        public ActionResult Index()
        {
            var groupList =
                new List<Group>
                {
                    new Group
                    {
                        Id = 1,
                        Name = "Овощи"
                    },
                    new Group
                    {
                        Id = 2,
                        Name = "Фрукты"
                    }
                };

            //return RedirectToAction("Add");
            return View(groupList);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Group model)
        {
            if (!ModelState.IsValid)
                return View(model);

            return Redirect($"http://wwww.facebook.com");
        }

        public ActionResult Update(int? id)
        {
            if (!id.HasValue)
                return RedirectToAction("Index");

            var group = new Group
            {
                Id = id.Value,
                Name = "Enter new Group"
            };
            return View(group);
        }

        [HttpPost]
        public ActionResult Update(Group model)
        {
            if (!ModelState.IsValid)
                return View(model);

            return Redirect($"http://wwww.facebook.com");
        }

    }
}