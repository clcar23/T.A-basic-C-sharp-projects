using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
           
            return View(db.Insurees.ToList());
        }

        // GET: Insuree
        public ActionResult AdminView()
        {

            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
           
           
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {

                insuree.Quote = calculateQuote(insuree);

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("AdminView");
            }

            return View(insuree);
        }

        public decimal calculateQuote(Insuree insuree)
        {
            // adding $50 to the base quote
            insuree.Quote = 50;
            decimal newQuote = 0;
            // getting the current year and comparing to the customer
            int customerAge = DateTime.Now.Year - insuree.DateOfBirth.Year;
            if (customerAge <= 18)
            {
                newQuote = insuree.Quote + 100;
            }
            if (customerAge >= 19 && customerAge <= 25)
            {
                newQuote = insuree.Quote + 50;
            }
            if (customerAge > 25)
            {
                newQuote = insuree.Quote + 25;
            }

            // adding rates based on the car's year
            if (insuree.CarYear < 2000)
            {
                newQuote = insuree.Quote + 25;
            }
            if (insuree.CarYear > 2015)
            {
                newQuote = insuree.Quote + 25;
            }

            // adding rates based on the car model
            if (insuree.CarModel == "Porsche")
            {
                newQuote = insuree.Quote + 25;
            }
            if (insuree.CarModel == "Porsche" && insuree.CarModel == "911 Carrera")
            {
                newQuote = insuree.Quote + 25;
            }

            // adding in speeding tickets
            newQuote = insuree.SpeedingTickets * 10;

            if (insuree.DUI == true)
            {
                decimal percentage = newQuote / .25m;
                newQuote = newQuote + percentage;
            }

            // adding in the cost of full coverage
            if (insuree.CoverageType == true)
            {
                decimal percentage = newQuote / .50m;
                newQuote = newQuote + percentage;
            }

            return insuree.Quote = newQuote;
        }
        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = calculateQuote(insuree);
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("AdminView");
            }
            return View(insuree);
        }
    
        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
