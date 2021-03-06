using MercadoAlpha.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoAlpha.Controllers
{
    [Authorize(AuthenticationSchemes = "CookieAuthentication")]
    public class FuncionariosController : Controller
    {
        private readonly Contexto db;
        public FuncionariosController(Contexto contexto)
        {
            db = contexto;
        }

        public ActionResult Index(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return View(db.FUNCIONARIOS.ToList());
            }
            else
            {
                return View(db.FUNCIONARIOS.Where(a => a.nomesocial.Contains(query) || a.cargo.Contains(query)));
            }

        }

        // GET: FuncionariosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FuncionariosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FuncionariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Funcionario collection)
        {
            try
            {
                db.FUNCIONARIOS.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Index");
            }
        }

        // GET: FuncionariosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.FUNCIONARIOS.Where(a=>a.Id==id).FirstOrDefault());
        }

        // POST: FuncionariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Funcionario dadosTela)
        {
            try
            {
                db.FUNCIONARIOS.Update(dadosTela);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       
        public ActionResult Delete(int id)
        {
            db.FUNCIONARIOS.Remove(db.FUNCIONARIOS.Where(a => a.Id == id).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("Index");
        }

       
    }
}
