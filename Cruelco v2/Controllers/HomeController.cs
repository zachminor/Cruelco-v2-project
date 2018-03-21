using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cruelco_v2;
using Cruelco_v2.Models;

namespace Cruelco_v2.Controllers
{
    public class HomeController : Controller
    {
        private JokeContext db = new JokeContext();

        public ActionResult Index()
        {
            return View(db.Joke.ToList());
            //using (var jokeContext = new JokeContext())
            //{
            //    var jokeList = new JokeListViewModel
            //    {
            //        //Convert each Joke to a JokeViewModel
            //        Joke = jokeContext.Joke.Select(p => new JokeViewModel
            //        {
            //            JokeId = p.JokeId,
            //            Opener = p.Opener,
            //            Punchline = p.Punchline
            //        }).ToList()
            //    };

            //    jokeList.TotalJokes = jokeList.Joke.Count;

            //    return View(jokeList);
            //}

            //return View(new JokeListViewModel());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public ActionResult JokeAdd()
        //{
        //    var vm = new JokeViewModel();
        //    return View(vm);
        //}
        //[HttpPost]
        //public ActionResult JokeAdd(JokeViewModel vm)
        //{
        //    using (var jokeContext = new JokeContext())
        //    {
        //        jokeContext.Joke.Add(new Joke { Opener = vm.Opener, Punchline = vm.Punchline });
        //        jokeContext.SaveChanges();
        //    }
        //    return View(vm);
        //}

        // GET: Jokes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Joke joke = db.Joke.Find(id);
            if (joke == null)
            {
                return HttpNotFound();
            }
            return View(joke);
        }

        // GET: Jokes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jokes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JokeId,Opener,Punchline")] Joke joke)
        {
            if (ModelState.IsValid)
            {
                db.Joke.Add(joke);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(joke);
        }

        // GET: Jokes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Joke joke = db.Joke.Find(id);
            if (joke == null)
            {
                return HttpNotFound();
            }
            return View(joke);
        }

        // POST: Jokes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JokeId,Opener,Punchline")] Joke joke)
        {
            if (ModelState.IsValid)
            {
                db.Entry(joke).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(joke);
        }

        // GET: Jokes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Joke joke = db.Joke.Find(id);
            if (joke == null)
            {
                return HttpNotFound();
            }
            return View(joke);
        }

        // POST: Jokes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Joke joke = db.Joke.Find(id);
            db.Joke.Remove(joke);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}