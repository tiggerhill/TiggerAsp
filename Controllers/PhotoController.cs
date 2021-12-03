using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiggerAsp.Data;
using TiggerAsp.Models;
using Microsoft.AspNetCore.Authorization;

namespace TiggerAsp.Controllers
{
    [Authorize]
    public class PhotoController : Controller
    {
        // This controller starts by defining a private PhotoContext property named context.
        private PhotoDbContext context;

        // Then, it uses its constructor to set that property
        public PhotoController(PhotoDbContext ctx)
        {
            context = ctx;
        }

        [Route("[controller]s/{id?}")]
        public IActionResult List(string id = "Home")  //  "Home" provides link to Photo/List.cshtml
        {
            var occasions = context.Occasions
                .OrderBy(o => o.OccasionId).ToList();

            List<Photo> photos;

            photos = context.Photos
                    .Where(o => o.Occasion.OccasionName == id)
                    .OrderBy(o => o.OccasionId).ToList();

            // use ViewBag to pass data to view
            ViewBag.Occasions = occasions;
            ViewBag.SelectedOccasionName = id;

            // bind photos to view
            return View(photos);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var photo = context.Photos.Find(id);
            return View(photo);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Photo photo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (photo.PhotoId == 0)
                    {
                        context.Photos.Add(photo);
                        return View();  // TODO: remove after getting the Add set up
                    }
                    else
                    {
                        context.Photos.Update(photo);
                        context.SaveChanges();
                        return RedirectToAction("Index", "Home");  // TODO: redirect to prior page
                    }
                }
                else
                {
                    ViewBag.Action = (photo.PhotoId == 0) ? "Add" : "Edit";
                    return View(photo);
                }
            }
            catch
            {
                return View();
            }
        }

        //public IActionResult ShowOccasionInfo(string id)
        //{
        //    var occasions = context.Occasions.ToList();

        //    Occasion occasion = context.Occasions.Find(id);

        //    // use ViewBag to pass data to view
        //    ViewBag.OccasionName = occasion.OccasionName;
        //    ViewBag.OccasionDesc = occasion.OccasionDescription;

        //    // bind occasion to view
        //    return View(occasion);
        //}

        public IActionResult Tree()
        {
            return View();
        }

        public IActionResult Memoriam()
        {
            return View();
        }




        // ____________________________________________________________

        // GET: Photo
        public ActionResult Index()
        {
            return View();
        }

        // GET: Photo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Photo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Photo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // GET: Photo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Photo/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}