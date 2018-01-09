using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Paper2.Models;

namespace Paper2.Controllers
{
    public class FirstTablesController : Controller
    {
        private Model1 db = new Model1();

        // GET: FirstTables
        public ActionResult Index()
        {
            return View(db.FirstTables.ToList());
        }

        // GET: FirstTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FirstTable firstTable = db.FirstTables.Find(id);
            if (firstTable == null)
            {
                return HttpNotFound();
            }
            return View(firstTable);
        }

        // GET: FirstTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FirstTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CarID,ProductID,Speed")] FirstTable firstTable)
        {
            if (ModelState.IsValid)
            {
                db.FirstTables.Add(firstTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(firstTable);
        }

        // GET: FirstTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FirstTable firstTable = db.FirstTables.Find(id);
            if (firstTable == null)
            {
                return HttpNotFound();
            }
            return View(firstTable);
        }

        // POST: FirstTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CarID,ProductID,Speed")] FirstTable firstTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(firstTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(firstTable);
        }

        // GET: FirstTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FirstTable firstTable = db.FirstTables.Find(id);
            if (firstTable == null)
            {
                return HttpNotFound();
            }
            return View(firstTable);
        }

        // POST: FirstTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FirstTable firstTable = db.FirstTables.Find(id);
            db.FirstTables.Remove(firstTable);
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
