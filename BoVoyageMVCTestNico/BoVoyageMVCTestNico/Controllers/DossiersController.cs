using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BoVoyageMVCTestNico.Data;
using BoVoyageMVCTestNico.Models;

namespace BoVoyageMVCTestNico.Controllers
{
    public class DossiersController : Controller
    {
        private BoVoyageMVCTestNicoDbContext db = new BoVoyageMVCTestNicoDbContext();

        // GET: Dossiers
        public ActionResult Index()
        {
            var dossiers = db.Dossiers.Include(d => d.Client).Include(d => d.Voyage);
            return View(dossiers.ToList());
        }

        // GET: Dossiers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dossier dossier = db.Dossiers.Find(id);
            if (dossier == null)
            {
                return HttpNotFound();
            }
            return View(dossier);
        }

        // GET: Dossiers/Create
        public ActionResult Create()
        {
            ViewBag.ClientID = new SelectList(db.Clients, "ID", "Nom");
            ViewBag.VoyageID = new SelectList(db.Voyages.Include(x => x.Destination), "ID", "Destination.Region");
            return View();
        }

        // POST: Dossiers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "nbParticipants,nbEnfants,ID,NumeroCarteBancaire,PrixTotal,Assurance,VoyageID,ClientID,CreatedAt,Deleted,DeletedAt")] Dossier dossier)
        {
            if (ModelState.IsValid)
            {
                db.Dossiers.Add(dossier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClientID = new SelectList(db.Clients, "ID", "Nom", dossier.ClientID);
            ViewBag.VoyageID = new SelectList(db.Voyages, "ID", "Destination", dossier.VoyageID);
            return View(dossier);
        }

        // GET: Dossiers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dossier dossier = db.Dossiers.Find(id);
            if (dossier == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClientID = new SelectList(db.Clients, "ID", "Email", dossier.ClientID);
            ViewBag.VoyageID = new SelectList(db.Voyages, "ID", "ID", dossier.VoyageID);
            return View(dossier);
        }

        // POST: Dossiers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NumeroCarteBancaire,PrixTotal,Assurance,VoyageID,ClientID,CreatedAt,Deleted,DeletedAt")] Dossier dossier)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dossier).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClientID = new SelectList(db.Clients, "ID", "Email", dossier.ClientID);
            ViewBag.VoyageID = new SelectList(db.Voyages, "ID", "ID", dossier.VoyageID);
            return View(dossier);
        }

        // GET: Dossiers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dossier dossier = db.Dossiers.Find(id);
            if (dossier == null)
            {
                return HttpNotFound();
            }
            return View(dossier);
        }

        // POST: Dossiers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dossier dossier = db.Dossiers.Find(id);
            db.Dossiers.Remove(dossier);
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
