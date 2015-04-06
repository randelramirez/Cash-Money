using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CashMoney.Core;
using CashMoney.Infrastructure;

namespace CashMoney.Web.Areas.Manage.Controllers
{
    public class IncomeController : Controller
    {
        private CashMoneyContext db = new CashMoneyContext();

        // GET: Manage/Income
        public ActionResult Index()
        {
            return View(db.Gross.ToList());
        }

        // GET: Manage/Income/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Income income = db.Gross.Find(id);
            if (income == null)
            {
                return HttpNotFound();
            }
            return View(income);
        }

        // GET: Manage/Income/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manage/Income/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,From,Amount,DateAdded")] Income income)
        {
            if (ModelState.IsValid)
            {
                db.Gross.Add(income);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(income);
        }

        // GET: Manage/Income/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Income income = db.Gross.Find(id);
            if (income == null)
            {
                return HttpNotFound();
            }
            return View(income);
        }

        // POST: Manage/Income/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,From,Amount,DateAdded")] Income income)
        {
            if (ModelState.IsValid)
            {
                db.Entry(income).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(income);
        }

        // GET: Manage/Income/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Income income = db.Gross.Find(id);
            if (income == null)
            {
                return HttpNotFound();
            }
            return View(income);
        }

        // POST: Manage/Income/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Income income = db.Gross.Find(id);
            db.Gross.Remove(income);
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
