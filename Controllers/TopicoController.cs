using Microsoft.AspNetCore.Mvc;
using WikiSistemaASP.NET.Models;
using WikiSistemaASP.NET.Data;
using System.Linq;

namespace WikiSistemaASP.NET.Controllers
{
    public class TopicoController : Controller
    {
        private readonly WikiDbContext _context;

        public TopicoController(WikiDbContext context)
        {
            _context = context;
        }

        // GET: /Topico/
        public IActionResult Index()
        {
            var topicos = _context.Topicos.ToList();
            return View(topicos);
        }

        // GET: /Topico/Details/5
        public IActionResult Details(int id)
        {
            var topico = _context.Topicos.Find(id);
            if (topico == null)
            {
                return NotFound();
            }
            return View(topico);
        }

        // GET: /Topico/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Topico/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Titulo,Conteudo,ModuloId")] Topico topico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(topico);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(topico);
        }

        // GET: /Topico/Edit/5
        public IActionResult Edit(int id)
        {
            var topico = _context.Topicos.Find(id);
            if (topico == null)
            {
                return NotFound();
            }
            return View(topico);
        }

        // POST: /Topico/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Titulo,Conteudo,ModuloId")] Topico topico)
        {
            if (id != topico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(topico);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Topicos.Any(e => e.Id == topico.Id))
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
            return View(topico);
        }

        // GET: /Topico/Delete/5
        public IActionResult Delete(int id)
        {
            var topico = _context.Topicos.Find(id);
            if (topico == null)
            {
                return NotFound();
            }
            return View(topico);
        }

        // POST: /Topico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var topico = _context.Topicos.Find(id);
            _context.Topicos.Remove(topico);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
