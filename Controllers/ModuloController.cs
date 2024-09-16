using Microsoft.AspNetCore.Mvc;
using WikiSistemaASP.NET.Models;
using WikiSistemaASP.NET.Data;

namespace WikiSistemaASP.NET.Controllers
{
    public class ModuloController : Controller
    {
        private readonly WikiDbContext _context;

        public ModuloController(WikiDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var modulos = _context.Modulos.ToList();
            return View(modulos);
        }

        public IActionResult Details(int id)
        {
            var modulo = _context.Modulos.Find(id);
            if (modulo == null)
            {
                return NotFound();
            }
            return View(modulo);
        }

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
            _context.Modulos.Remove(modulo);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
