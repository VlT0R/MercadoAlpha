using MercadoAlpha.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoAlpha.Controllers
{
    public class ClientesController : Controller
    {
        private readonly Contexto db;
        public ClientesController(Contexto contexto)
        {
            db = contexto;
        }
        // GET: ClientesController
        public ActionResult Index()
        {
            return View(db.CLIENTES.ToList());
        }

        // GET: ClientesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Clientes collection)
        {
            try
            {
                db.CLIENTES.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Index");
            }
        }

        // GET: ClientesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.CLIENTES.Where(a=> a.Id == id).FirstOrDefault());
        }

        // POST: ClientesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Clientes dadosTela)
        {
            try
            {
                db.CLIENTES.Update(dadosTela);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesController/Delete/5
        public ActionResult Delete(int id)
        {
            db.CLIENTES.Remove(db.CLIENTES.Where(a => a.Id==id).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: ClientesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
