using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using carteiraAcoes.Entity;
using carteiraAcoes.Models;

namespace carteiraAcoes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SerieController : ControllerBase
    {
        private readonly BancoContext _context;

        public SerieController(BancoContext context)
        {
            _context = context;
        }

        // GET: api/Serie
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Serie>>> Getserie()
        {
            return await _context.serie.ToListAsync();
        }

        // GET: api/Serie/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Serie>> GetSerie(int id)
        {
            var serie = await _context.serie.FindAsync(id);

            if (serie == null)
            {
                return NotFound();
            }

            return serie;
        }

        // PUT: api/Serie/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<ActionResult<Serie>> PutSerie(int id, Serie serie)
        {
            if (id != serie.SerieId)
            {
                return BadRequest();
            }

            _context.Entry(serie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SerieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return serie;
        }

        // POST: api/Serie
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Serie>> PostSerie(Serie serie)
        {
            _context.serie.Add(serie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSerie", new { id = serie.SerieId }, serie);
        }

        // DELETE: api/Serie/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Serie>> DeleteSerie(int id)
        {
            var serie = await _context.serie.FindAsync(id);
            if (serie == null)
            {
                return NotFound();
            }

            _context.serie.Remove(serie);
            await _context.SaveChangesAsync();

            return serie;
        }

        private bool SerieExists(int id)
        {
            return _context.serie.Any(e => e.SerieId == id);
        }
    }
}
