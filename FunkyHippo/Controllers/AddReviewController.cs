using FunkyHippo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FunkyHippo.Controllers
{
    public class AddReviewController : Controller
    {
        // GET: AddReview
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OurLove()
        {
            var albumNum = 1;
            FunkyHippoContext db = new FunkyHippoContext();
            var reviews = (from b in db.Reviews
                           where b.AlbumID == albumNum
                           select b);

            var sumRating = (from a in db.Reviews
                             where a.AlbumID == albumNum
                             select a.Rating).Sum();

            var countUsers = (from c in db.Reviews
                             where c.AlbumID == albumNum
                             select c.Rating).Count();

            var aggRating = sumRating / countUsers;
            ViewBag.AggRate = aggRating;

            return View(reviews.ToList());
        }

        public ActionResult RTJ2()
        {
            var albumNum = 2;
            FunkyHippoContext db = new FunkyHippoContext();
            var reviews = (from b in db.Reviews
                           where b.AlbumID == albumNum
                           select b);

            var sumRating = (from a in db.Reviews
                             where a.AlbumID == albumNum
                             select a.Rating).Sum();

            var countUsers = (from c in db.Reviews
                              where c.AlbumID == albumNum
                              select c.Rating).Count();

            var aggRating = sumRating / countUsers;
            ViewBag.AggRate = aggRating;

            return View(reviews.ToList());
        }
    }
}