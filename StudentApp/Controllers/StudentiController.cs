using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentApp.Data;
using StudentApp.Models;
using System.Threading.Tasks;

namespace StudentApp.Controllers
{
    public class StudentiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET per visualizzare gli studenti
        public async Task<IActionResult> Index()
        {
            var studenti = await _context.Studenti.ToListAsync();
            return View(studenti);
        }

        // GET per visualizzare i dettagli di uno studente
        public async Task<IActionResult> Dettagli(int? id)
        {
            if (id == null)
                return NotFound();

            var studente = await _context.Studenti
                .FirstOrDefaultAsync(s => s.Id == id);

            if (studente == null)
                return NotFound();

            return PartialView("DettagliStudente", studente);
        }
    }
}
