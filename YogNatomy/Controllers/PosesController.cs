using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YogNatomy.Models;

namespace YogNatomy.Controllers
{
    public class PosesController : Controller
    {
        private YogNatomyContext db = new YogNatomyContext();

        // GET: Poses
        public ActionResult Index()
        {
            return View(db.Poses.ToList());
        }

        // GET: Poses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pose pose = db.Poses.Find(id);
            if (pose == null)
            {
                return HttpNotFound();
            }
            return View(pose);
        }

        // GET: Poses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Poses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Class,ClassId,PrimaryMuscle,SecondaryMuscle,FitnessLevel")] Pose pose)
        {
            if (ModelState.IsValid)
            {
                db.Poses.Add(pose);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pose);
        }

        // GET: Poses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pose pose = db.Poses.Find(id);
            if (pose == null)
            {
                return HttpNotFound();
            }
            return View(pose);
        }

        // POST: Poses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Class,ClassId,PrimaryMuscle,SecondaryMuscle,FitnessLevel")] Pose pose)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pose).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pose);
        }

        // GET: Poses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pose pose = db.Poses.Find(id);
            if (pose == null)
            {
                return HttpNotFound();
            }
            return View(pose);
        }

        // POST: Poses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pose pose = db.Poses.Find(id);
            db.Poses.Remove(pose);
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
