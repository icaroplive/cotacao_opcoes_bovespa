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
    public class OpcaoController : ControllerBase
    {
        private readonly BancoContext _context;

        public OpcaoController(BancoContext context)
        {
            _context = context;
        }

        // GET: api/Opcao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Opcao>>> Getopcao()
        {
            return await _context.opcao.ToListAsync();
        }

        // GET: api/Opcao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Opcao>> GetOpcao(int id)
        {
            var opcao = await _context.opcao.FindAsync(id);

            if (opcao == null)
            {
                return NotFound();
            }

            return opcao;
        }

        // PUT: api/Opcao/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<ActionResult<Opcao>> PutOpcao(int id, Opcao opcao)
        {
            if (id != opcao.OpcaoId)
            {
                return BadRequest();
            }

            _context.Entry(opcao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OpcaoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return UpdatedAtAction("GetOpcao", new { id = opcao.OpcaoId }, opcao);
        }

        // POST: api/Opcao
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Opcao>> PostOpcao(Opcao opcao)
        {
            _context.opcao.Add(opcao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOpcao", new { id = opcao.OpcaoId }, opcao);
        }

        // DELETE: api/Opcao/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Opcao>> DeleteOpcao(int id)
        {
            var opcao = await _context.opcao.FindAsync(id);
            if (opcao == null)
            {
                return NotFound();
            }

            _context.opcao.Remove(opcao);
            await _context.SaveChangesAsync();

            return opcao;
        }

        private bool OpcaoExists(int id)
        {
            return _context.opcao.Any(e => e.OpcaoId == id);
        }
    }
}
