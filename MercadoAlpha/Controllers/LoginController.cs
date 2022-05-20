using MercadoAlpha.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MercadoAlpha.Controllers
{
    public class LoginController : Controller
    {
        private readonly Contexto db;

        public LoginController(Contexto contexto)
        {
            db = contexto;
        }

        // GET: LoginController
        public ActionResult Entrar(string ReturnUrl)
        {
            TempData["Url"] = ReturnUrl;
            return View();
        }

        // GET: LoginController/Details/5
        [HttpPost]
        public async Task<IActionResult> Entrar(string login, string senha, string ReturnUrl)
        {
            Usuarios usuarioLogado = db.USUARIOS.Where(a => a.Login == login && a.Senha == senha).FirstOrDefault();

            if(usuarioLogado == null)
            {
                TempData["erro"] = "Usuario e senha invalidos";
                return View();
            }

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, usuarioLogado.Login));
            claims.Add(new Claim(ClaimTypes.Sid, usuarioLogado.Id.ToString()));

            var userIdentity = new ClaimsIdentity(claims, "Acesso");

            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync("CookieAuthentication", principal, new AuthenticationProperties());


            return Redirect(ReturnUrl);
        }

        public async Task<IActionResult> Logoff()
        {
            await HttpContext.SignOutAsync("CookieAuthentication");
            return Redirect("/Login/Entrar");
        }



        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
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
