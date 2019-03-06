using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BiblionetModel.DAL;
using BiblionetModel.Models;

namespace Biblionet.Controllers
{
    public class RegistroController : Controller
    {
        private LibroContext db = new LibroContext();

        // GET: Registro
        public ActionResult Index()
        {
            var registros = db.Registros.Include(r => r.Asignatura).Include(r => r.Libro);
            return View(registros.ToList());
        }

        // GET: Registro/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registro registro = db.Registros.Find(id);
            if (registro == null)
            {
                return HttpNotFound();
            }
            return View(registro);
        }

        // GET: Registro/Create
        public ActionResult Create()
        {
            ViewBag.AsignaturaID = new SelectList(db.Asignaturas, "AsignaturaID", "Asignatura");
            ViewBag.LibroID = new SelectList(db.Libros, "LibroID", "Titulo");
            return View();
        }

        // POST: Registro/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RegistroID,AsignaturaID,LibroID")] Registro registro)
        {
            if (ModelState.IsValid)
            {
                db.Registros.Add(registro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AsignaturaID = new SelectList(db.Asignaturas, "AsignaturaID", "ASIGNATURA", registro.AsignaturaID);
            ViewBag.LibroID = new SelectList(db.Libros, "LibroID", "Titulo", registro.LibroID);
            return View(registro);
        }

        // GET: Registro/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registro registro = db.Registros.Find(id);
            if (registro == null)
            {
                return HttpNotFound();
            }
            ViewBag.AsignaturaID = new SelectList(db.Asignaturas, "AsignaturaID", "ASIGNATURA", registro.AsignaturaID);
            ViewBag.LibroID = new SelectList(db.Libros, "LibroID", "Titulo", registro.LibroID);
            return View(registro);
        }

        // POST: Registro/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RegistroID,AsignaturaID,LibroID")] Registro registro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AsignaturaID = new SelectList(db.Asignaturas, "AsignaturaID", "ASIGNATURA", registro.AsignaturaID);
            ViewBag.LibroID = new SelectList(db.Libros, "LibroID", "Titulo", registro.LibroID);
            return View(registro);
        }

        // GET: Registro/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registro registro = db.Registros.Find(id);
            if (registro == null)
            {
                return HttpNotFound();
            }
            return View(registro);
        }

        // POST: Registro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Registro registro = db.Registros.Find(id);
            db.Registros.Remove(registro);
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
