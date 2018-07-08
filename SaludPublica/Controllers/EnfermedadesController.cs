﻿using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SaludPublica.Data;
using SaludPublica.Models;
using SaludPublica.ViewModels;

namespace SaludPublica.Controllers
{
    public class EnfermedadesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EnfermedadesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Enfermedads
        public async Task<IActionResult> Index()
        {
            return View(await _context.Enfermedades.ToListAsync());
        }

        // GET: Enfermedads/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enfermedad = await _context.Enfermedades
                .SingleOrDefaultAsync(m => m.EnfermedadID == id);
            if (enfermedad == null)
            {
                return NotFound();
            }

            return View(enfermedad);
        }

        // GET: Enfermedads/Create
        public async Task<IActionResult> Create()
        {
            var ViewModel = new SintomasPorEnfermedadViewModel()
            {
                Sintomas = await _context.Sintomas.ToListAsync()
            };
            return View(ViewModel);
        }

        // POST: Enfermedads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Enfermedad enfermedad,ICollection<int> sintomas)
        {
            if (ModelState.IsValid)
            {
               _context.Add(enfermedad);
                var lista = new List<SintomaPorEnfermedades>();
                foreach (var item in sintomas)
                {
                    lista.Add(
                        new SintomaPorEnfermedades() { Enfermedad = enfermedad, Sintoma = _context.Sintomas.SingleOrDefault(s => s.SintomaID == item) }
                    );
                }
                foreach (var item in lista)
                {
                    _context.Add(item);
                }
               await _context.SaveChangesAsync();
               return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Enfermedads/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enfermedad = await _context.Enfermedades.SingleOrDefaultAsync(m => m.EnfermedadID == id);
            if (enfermedad == null)
            {
                return NotFound();
            }
            var query = from registro in await _context.sintomaPorEnfermedades.ToListAsync()
                        join sintoma in await _context.Sintomas.ToListAsync() on registro.SintomaID equals sintoma.SintomaID
                        where registro.EnfermedadID == enfermedad.EnfermedadID
                        select sintoma;
            var viewModel = new SintomasPorEnfermedadViewModel()
            {
                Enfermedad = enfermedad,
                Sintomas = new List<Sintoma>()
            };
            foreach (var item in query)
            {
                viewModel.Sintomas.Add(item);
            }
            return View(viewModel);
        }

        // POST: Enfermedads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EnfermedadID,Nombre")] Enfermedad enfermedad,ICollection<int> sintomas)
        {
            if (id != enfermedad.EnfermedadID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enfermedad);
                    var query = from registro in await _context.sintomaPorEnfermedades.ToListAsync()
                                join sintoma in await _context.Sintomas.ToListAsync() on registro.SintomaID equals sintoma.SintomaID
                                where registro.EnfermedadID == enfermedad.EnfermedadID
                                select registro;
                    foreach (var item in query)
                    {
                        _context.sintomaPorEnfermedades.Remove(item);
                    }
                    var lista = new List<SintomaPorEnfermedades>();
                    foreach (var item in sintomas)
                    {
                        lista.Add(new SintomaPorEnfermedades() {  Enfermedad = enfermedad, Sintoma = await _context.Sintomas.SingleAsync(s => s.SintomaID == item)});
                    }
                    foreach (var item in lista)
                    {
                        _context.Add(item);
                    }
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnfermedadExists(enfermedad.EnfermedadID))
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
            return View(enfermedad);
        }

        // GET: Enfermedads/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enfermedad = await _context.Enfermedades
                .SingleOrDefaultAsync(m => m.EnfermedadID == id);
            if (enfermedad == null)
            {
                return NotFound();
            }

            return View(enfermedad);
        }

        // POST: Enfermedads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enfermedad = await _context.Enfermedades.SingleOrDefaultAsync(m => m.EnfermedadID == id);
            _context.Enfermedades.Remove(enfermedad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnfermedadExists(int id)
        {
            return _context.Enfermedades.Any(e => e.EnfermedadID == id);
        }
    }
}
