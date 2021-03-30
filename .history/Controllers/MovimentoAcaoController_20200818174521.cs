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
    public class MovimentoAcaoController : ControllerBase
    {
        private readonly BancoContext _context;

        public MovimentoAcaoController(BancoContext context)
        {
            _context = context;
        }

        // GET: api/MovimentoAcao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovimentoAcao>>> GetmovimentoAcao()
        {
            return await _context.movimentoAcao.ToListAsync();
        }

        // GET: api/MovimentoAcao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovimentoAcao>> GetMovimentoAcao(int id)
        {
            var movimentoAcao = await _context.movimentoAcao.FindAsync(id);

            if (movimentoAcao == null)
            {
                return NotFound();
            }

            return movimentoAcao;
        }

        // PUT: api/MovimentoAcao/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovimentoAcao(int id, MovimentoAcao movimentoAcao)
        {
            if (id != movimentoAcao.MovimentoAcaoId)
            {
                return BadRequest();
            }

            _context.Entry(movimentoAcao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovimentoAcaoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MovimentoAcao
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MovimentoAcao>> PostMovimentoAcao(MovimentoAcao movimentoAcao)
        {
            _context.movimentoAcao.Add(movimentoAcao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovimentoAcao", new { id = movimentoAcao.id }, movimentoAcao);
        }

        // DELETE: api/MovimentoAcao/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MovimentoAcao>> DeleteMovimentoAcao(int id)
        {
            var movimentoAcao = await _context.movimentoAcao.FindAsync(id);
            if (movimentoAcao == null)
            {
                return NotFound();
            }

            _context.movimentoAcao.Remove(movimentoAcao);
            await _context.SaveChangesAsync();

            return movimentoAcao;
        }

        private bool MovimentoAcaoExists(int id)
        {
            return _context.movimentoAcao.Any(e => e.id == id);
        }
    }
}
