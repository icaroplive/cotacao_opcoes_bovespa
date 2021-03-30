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
    public class DashController : ControllerBase
    {
        private readonly BancoContext _context;

        public DashController(BancoContext context)
        {
            _context = context;
        }

        // GET: api/dash
        [HttpGet]
        public async Task<ActionResult<IEnumerable<dash>>> Getdash()
        {
            return await _context.dash.ToListAsync();
        }

        // GET: api/dash/5
        [HttpGet("{id}")]
        public async Task<ActionResult<dash>> Getdash(int id)
        {
            var dash = await _context.dash.FindAsync(id);

            if (dash == null)
            {
                return NotFound();
            }

            return dash;
        }

        // PUT: api/dash/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<ActionResult<dash>> Putdash(int id, dash dash)
        {
            if (id != dash.dashId)
            {
                return BadRequest();
            }

            _context.Entry(dash).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!dashExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return dash;
        }

        // POST: api/dash
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<dash>> Postdash(dash dash)
        {
            _context.dash.Add(dash);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getdash", new { id = dash.dashId }, dash);
        }

        // DELETE: api/dash/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<dash>> Deletedash(int id)
        {
            var dash = await _context.dash.FindAsync(id);
            if (dash == null)
            {
                return NotFound();
            }

            _context.dash.Remove(dash);
            await _context.SaveChangesAsync();

            return dash;
        }

        private bool dashExists(int id)
        {
            return _context.dash.Any(e => e.dashId == id);
        }
    }
}
