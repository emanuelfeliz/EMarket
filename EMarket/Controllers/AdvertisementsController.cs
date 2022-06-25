using EMarket.Data;
using EMarket.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket.Controllers
{
    public class AdvertisementsController : Controller
    {
        private readonly ApplicationDbContext context;

        public AdvertisementsController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Categories> categoryList = new List<Categories>();

            categoryList = (from category in context.Categories
                            select category).ToList();

            categoryList.Insert(0, new Categories { CategoryId = 0,   CategoryName = "Select" });

            ViewBag.ListofCategory = context.Categories.ToList();

            var result = this.context.Advertisements.ToList();

            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }


        [HttpPost]
        public IActionResult Create(Advertesiments advertesiments)
        {
            if (ModelState.IsValid)
            {
                var adver = new Advertesiments()
                {
                    Images = advertesiments.Images,
                    ArticleName = advertesiments.ArticleName,
                    Price = advertesiments.Price,
                    Description = advertesiments.Description,
                    //Categories = advertesiments.Categories,
                    Date = advertesiments.Date


                };
                this.context.Advertisements.Add(adver);
                this.context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Empty field Can't Submit";
                return View(advertesiments);
            }
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var advertesiments = context.Advertisements.Find(id);
            if (advertesiments == null)
            {
                return NotFound();
            }

            return View(advertesiments);
        }


    }
}
