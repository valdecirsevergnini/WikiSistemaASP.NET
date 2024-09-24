using Microsoft.AspNetCore.Mvc;
using WikiSistemaASP.NET.Models;
using WikiSistemaASP.NET.Data;
using Microsoft.EntityFrameworkCore;

namespace WikiSistemaASP.NET.Controllers
{
    public class ModuloController : Controller
    {
        private readonly WikiDbContext _context;

        public ModuloController(WikiDbContext context)
        {
            _context = context;
        }

        // Lista todos os módulos
        public IActionResult Index()
        {
            var modulos = _context.Modulos.Include(m => m.Topicos).ToList();
            return View(modulos);
        }

        // Detalhes de um módulo específico
        public IActionResult Details(int id)
        {
            var modulo = _context.Modulos.Include(m => m.Topicos).FirstOrDefault(m => m.Id == id);
            if (modulo == null)
            {
                return NotFound();
            }
            return View(modulo);
        }

        // Criação de um novo módulo
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Nome")] Modulo modulo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(modulo);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(modulo);
        }

        // Edição de um módulo existente
        public IActionResult Edit(int id)
        {
            var modulo = _context.Modulos.Find(id);
            if (modulo == null)
            {
                return NotFound();
            }
            return View(modulo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Nome")] Modulo modulo)
        {
            if (id != modulo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modulo);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Modulos.Any(e => e.Id == modulo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(modulo);
        }

        // Excluir um módulo
        public IActionResult Delete(int id)
        {
            var modulo = _context.Modulos.Find(id);
            if (modulo == null)
            {
                return NotFound();
            }
            return View(modulo);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var modulo = _context.Modulos.Find(id);
            if (modulo != null)
            {
                _context.Modulos.Remove(modulo);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
        
        // Ação para gerenciar tópicos de um módulo específico
        public IActionResult ManageTopics(int id)
        {
            var modulo = _context.Modulos.Include(m => m.Topicos).FirstOrDefault(m => m.Id == id);
            if (modulo == null)
            {
                return NotFound();
            }
            return View(modulo);
        }
    }
}
