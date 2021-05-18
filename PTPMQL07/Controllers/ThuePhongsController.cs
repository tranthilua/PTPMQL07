using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PTPMQL07.Models;

namespace PTPMQL07.Controllers
{
    public class ThuePhongsController : Controller
    {
        private DemoDbContext db = new DemoDbContext();
        [Authorize]
        // GET: ThuePhongs
        public ActionResult Index()
        {
            return View(db.ThuePhongs.ToList());
        }

        // GET: ThuePhongs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThuePhong thuePhong = db.ThuePhongs.Find(id);
            if (thuePhong == null)
            {
                return HttpNotFound();
            }
            return View(thuePhong);
        }

        // GET: ThuePhongs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThuePhongs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TenPhong,ViTri,Loai,TinhTrang,Gia")] ThuePhong thuePhong)
        {
            if (ModelState.IsValid)
            {
                db.ThuePhongs.Add(thuePhong);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(thuePhong);
        }

        // GET: ThuePhongs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThuePhong thuePhong = db.ThuePhongs.Find(id);
            if (thuePhong == null)
            {
                return HttpNotFound();
            }
            return View(thuePhong);
        }

        // POST: ThuePhongs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TenPhong,ViTri,Loai,TinhTrang,Gia")] ThuePhong thuePhong)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thuePhong).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thuePhong);
        }

        // GET: ThuePhongs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThuePhong thuePhong = db.ThuePhongs.Find(id);
            if (thuePhong == null)
            {
                return HttpNotFound();
            }
            return View(thuePhong);
        }

        // POST: ThuePhongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ThuePhong thuePhong = db.ThuePhongs.Find(id);
            db.ThuePhongs.Remove(thuePhong);
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
