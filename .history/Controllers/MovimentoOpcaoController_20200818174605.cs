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
    public class MovimentoOpcaoController : ControllerBase
    {
        private readonly BancoContext _context;

        public MovimentoOpcaoController(BancoContext context)
        {
            _context = context;
        }

        // GET: api/MovimentoOpcao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovimentoOpcao>>> GetmovimentoOpcao()
        {
            return await _context.movimentoOpcao.ToListAsync();
        }

        // GET: api/MovimentoOpcao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovimentoOpcao>> GetMovimentoOpcao(int id)
        {
            var movimentoOpcao = await _context.movimentoOpcao.FindAsync(id);

            if (movimentoOpcao == null)
            {
                return NotFound();
            }

            return movimentoOpcao;
        }

        // PUT: api/MovimentoOpcao/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovimentoOpcao(int id, MovimentoOpcao movimentoOpcao)
        {
            if (id != movimentoOpcao.MovimentoOpcaoid)
            {
                return BadRequest();
            }

            _context.Entry(movimentoOpcao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovimentoOpcaoExists(id))
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

        // POST: api/MovimentoOpcao
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MovimentoOpcao>> PostMovimentoOpcao(MovimentoOpcao movimentoOpcao)
        {
            _context.movimentoOpcao.Add(movimentoOpcao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovimentoOpcao", new { id = movimentoOpcao.MovimentoOpcaoId}, movimentoOpcao);
        }

        // DELETE: api/MovimentoOpcao/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MovimentoOpcao>> DeleteMovimentoOpcao(int id)
        {
            var movimentoOpcao = await _context.movimentoOpcao.FindAsync(id);
            if (movimentoOpcao == null)
            {
                return NotFound();
            }

            _context.movimentoOpcao.Remove(movimentoOpcao);
            await _context.SaveChangesAsync();

            return movimentoOpcao;
        }

        private bool MovimentoOpcaoExists(int id)
        {
            return _context.movimentoOpcao.Any(e => e.id == id);
        }
    }
}
