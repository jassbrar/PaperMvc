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
    public class SecondTablesController : Controller
    {
        private Model1 db = new Model1();

        // GET: SecondTables
        public ActionResult Index()
        {
            return View(db.SecondTables.ToList());
        }

        // GET: SecondTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondTable secondTable = db.SecondTables.Find(id);
            if (secondTable == null)
            {
                return HttpNotFound();
            }
            return View(secondTable);
        }

        // GET: SecondTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SecondTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Year,CarID,Milage")] SecondTable secondTable)
        {
            if (ModelState.IsValid)
            {
                db.SecondTables.Add(secondTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(secondTable);
        }

        // GET: SecondTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondTable secondTable = db.SecondTables.Find(id);
            if (secondTable == null)
            {
                return HttpNotFound();
            }
            return View(secondTable);
        }

        // POST: SecondTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Year,CarID,Milage")] SecondTable secondTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(secondTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(secondTable);
        }

        // GET: SecondTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondTable secondTable = db.SecondTables.Find(id);
            if (secondTable == null)
            {
                return HttpNotFound();
            }
            return View(secondTable);
        }

        // POST: SecondTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SecondTable secondTable = db.SecondTables.Find(id);
            db.SecondTables.Remove(secondTable);
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
