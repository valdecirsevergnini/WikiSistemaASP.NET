using Microsoft.AspNetCore.Mvc;
using WikiSistemaASP.NET.Models;
using WikiSistemaASP.NET.Data;
using Microsoft.AspNetCore.Http;

namespace WikiSistemaASP.NET.Controllers
{
    public class AdminController : Controller
    {
        private readonly WikiDbContext _context;

        public AdminController(WikiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Usuario usuario)
        {
            // Simulação de validação de login
            var user = _context.Usuarios.FirstOrDefault(u => u.Username == usuario.Username && u.PasswordHash == usuario.PasswordHash);
            if (user != null)
            {
                // Armazena o ID do usuário na sessão
                HttpContext.Session.SetInt32("UserId", user.Id);
                return RedirectToAction("Index", "Modulo"); // Redireciona para a página de módulos após login
            }

            ModelState.AddModelError("", "Nome de usuário ou senha inválidos.");
            return View(usuario);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserId");
            return RedirectToAction("Index", "Home");
        }
    }
}
