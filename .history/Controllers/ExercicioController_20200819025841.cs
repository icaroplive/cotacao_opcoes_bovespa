using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using carteiraAcoes.Entity;
using carteiraAcoes.Models;
using carteiraAcoes.Models.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace carteiraAcoes.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class ExercicioController : ControllerBase {
        private readonly BancoContext _context;

        public exercicioController (BancoContext context) {
            _context = context;
        }

        // GET: api/exercicio
        /*        [HttpGet]
                public async Task<ActionResult<IEnumerable<Exercicio>>> Getexercicio()
                {
                    return await _context.exercicio.ToListAsync();
                }

                // GET: api/exercicio/5
                [HttpGet("{id}")]
                public async Task<ActionResult<exercicio>> Getexercicio(int id)
                {
                    var exercicio = await _context.exercicio.FindAsync(id);

                    if (exercicio == null)
                    {
                        return NotFound();
                    }

                    return exercicio;
                }

                // PUT: api/exercicio/5
                // To protect from overposting attacks, please enable the specific properties you want to bind to, for
                // more details see https://aka.ms/RazorPagesCRUD.
                [HttpPut("{id}")]
                public async Task<ActionResult<exercicio>> Putexercicio(int id, exercicio exercicio)
                {
                    if (id != exercicio.exercicioId)
                    {
                        return BadRequest();
                    }

                    _context.Entry(exercicio).State = EntityState.Modified;

                    try
                    {
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!exercicioExists(id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }

                    return exercicio;
                }
        */
        // POST: api/exercicio
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MovimentoOpcao>> Postexercicio (Exercicio exercicio) {
            var movimentoOpcao = _context.movimentoOpcao.Find (exercicio.MovimentoOpcaoId);

            if (exercicio.Exerceu) {

            }
            // _context.exercicio.Add(exercicio);
            // await _context.SaveChangesAsync();

            return CreatedAtAction ("Getexercicio", new { id = exercicio.exercicioId }, exercicio);
        }

        // DELETE: api/exercicio/5
        [HttpDelete ("{id}")]
        public async Task<ActionResult<exercicio>> Deleteexercicio (int id) {
            var exercicio = await _context.exercicio.FindAsync (id);
            if (exercicio == null) {
                return NotFound ();
            }

            _context.exercicio.Remove (exercicio);
            await _context.SaveChangesAsync ();

            return exercicio;
        }

        private bool exercicioExists (int id) {
            return _context.exercicio.Any (e => e.exercicioId == id);
        }
    }
}