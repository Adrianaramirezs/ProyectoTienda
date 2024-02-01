using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sincronias.Models;

namespace Sincronias.Controllers
{
    public class UserController : Controller
    {
       // private X db = new X();

        // GET: User
        public ActionResult Index()
        {
           //  List<Usuario> users = db.Users.ToList();
            return View(users);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(Usuario user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
                 user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }

            return View(user);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(Usuario user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            Usuario user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }

            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Usuario user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }

            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            Usuario user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }

            return View(user);
        }

        // Dispose method
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
