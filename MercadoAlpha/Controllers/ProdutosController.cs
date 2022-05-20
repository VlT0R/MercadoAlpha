
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
    public class ProdutosController : Controller
    {
        private readonly Contexto db;
        public ProdutosController(Contexto contexto)
        {
            db = contexto;
        }
        // GET: ProdutosController
        public ActionResult Index()
        {
            return View( db.PRODUTOS.ToList() );
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
  

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produtos collection)
        {
            try
            {
                db.PRODUTOS.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Index");
            }
        }

        

        // GET: ProdutosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProdutosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Produtos dadosTela)
        {
            try
            {
                db.PRODUTOS.Update(dadosTela);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutosController/Delete/5
        public ActionResult Delete(int id)
        {
            db.PRODUTOS.Remove(db.PRODUTOS.Where(a => a.Id == id).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: ProdutosController/Delete/5
       
    }
}
