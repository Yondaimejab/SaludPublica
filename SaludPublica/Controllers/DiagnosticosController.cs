using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SaludPublica.Data;
using SaludPublica.Models;

namespace SaludPublica.Controllers
{
    public class DiagnosticosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _UserManager;

        public DiagnosticosController(ApplicationDbContext context, UserManager<ApplicationUser> UserManager)
        {
            _context = context;
            _UserManager = UserManager;
        }

        // GET: Diagnosticoes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Diagnosticos.Include(d => d.Paciente).Include(d => d.Enfermedad).Include(d => d.Doctor);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Diagnosticoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnostico = await _context.Diagnosticos
                .Include(d => d.Paciente).Include(d=> d.Enfermedad).Include(d => d.Doctor)
                .SingleOrDefaultAsync(m => m.DiagnosticoID == id);
            if (diagnostico == null)
            {
                return NotFound();
            }

            return View(diagnostico);
        }

        // GET: Diagnosticoes/Create
        public IActionResult Create()
        {
            ViewData["PacienteID"] = new SelectList(_context.Pacientes, "PacienteID", "Nombre");
            ViewData["EnfermedadID"] = new SelectList(_context.Enfermedades,"EnfermedadID","Nombre");
            return View();
        }

        // POST: Diagnosticoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DiagnosticoID,PacienteID,EnfermedadID,Comment")] Diagnostico diagnostico)
        {
            if (ModelState.IsValid)
            {
                diagnostico.Date = DateTime.Now;
                diagnostico.Doctor = await _UserManager.GetUserAsync(HttpContext.User);
                _context.Add(diagnostico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PacienteID"] = new SelectList(_context.Pacientes, "PacienteID", "PacienteID", diagnostico.PacienteID);
            ViewData["EnfermedadID"] = new SelectList(_context.Enfermedades, "EnferemedadID", "EnferemedadID", diagnostico.EnfermedadID);
            return View(diagnostico);
        }

        // GET: Diagnosticoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnostico = await _context.Diagnosticos.Include(d => d.Paciente).Include(d => d.Enfermedad).Include(d => d.Doctor).SingleOrDefaultAsync(m => m.DiagnosticoID == id);
            if (diagnostico == null)
            {
                return NotFound();
            }
            ViewData["PacienteID"] = new SelectList(_context.Pacientes, "PacienteID", "Nombre", diagnostico.PacienteID);
            ViewData["EnfermedadID"] = new SelectList(_context.Enfermedades, "EnfermedadID", "Nombre", diagnostico.PacienteID);

            return View(diagnostico);
        }

        // POST: Diagnosticoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DiagnosticoID,PacienteID,EnfermedadID,Comment")] Diagnostico diagnostico)
        {
            if (id != diagnostico.DiagnosticoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    diagnostico.Doctor = await _UserManager.GetUserAsync(HttpContext.User);
                    _context.Update(diagnostico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiagnosticoExists(diagnostico.DiagnosticoID))
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
            ViewData["PacienteID"] = new SelectList(_context.Pacientes, "PacienteID", "Nombre", diagnostico.PacienteID);
            ViewData["EnfermedadID"] = new SelectList(_context.Enfermedades, "EnfermeadadID", "Nombre", diagnostico.PacienteID);

            return View(diagnostico);
        }

        // GET: Diagnosticoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnostico = await _context.Diagnosticos
                .Include(d => d.Paciente).Include(d => d.Enfermedad).Include(d => d.Doctor)
                .SingleOrDefaultAsync(m => m.DiagnosticoID == id);
            if (diagnostico == null)
            {
                return NotFound();
            }

            return View(diagnostico);
        }

        // POST: Diagnosticoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diagnostico = await _context.Diagnosticos.SingleOrDefaultAsync(m => m.DiagnosticoID == id);
            _context.Diagnosticos.Remove(diagnostico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiagnosticoExists(int id)
        {
            return _context.Diagnosticos.Any(e => e.DiagnosticoID == id);
        }
    }
}
