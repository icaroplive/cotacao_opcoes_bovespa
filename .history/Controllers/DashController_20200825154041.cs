using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using carteiraAcoes.Entity;
using carteiraAcoes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace carteiraAcoes.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class DashController : ControllerBase {
        private readonly BancoContext _context;

        public DashController (BancoContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dash>>> Getdash () {

            //return _context.movimentoAcao.Where (c => c.Vendido == true).GroupBy (c => new { c.AcaoId, c.DataVenda }).Select (c => c).ToListAsync ();
            var ew = _context.movimentoAcao.Include(c => c.Acao).Where(c => c.Vendido).AsEnumerable ().GroupBy (c => new { c.AcaoId })
                .Select (c => new Dash() { Quantidade = c.Sum(c => c.Quantidade), Acao = c.Key.AcaoId}).ToList();
            /*var x = await (from c in _context.movimentoAcao where c.Vendido group c by new { c.AcaoId } into grp

                select new Dash { Acao = grp., Quantidade = grp.Sum (c => c.Quantidade), Lucro = grp.Sum (c => c.Quantidade) * (grp.Sum (c => c.ValorVenda) - grp.Sum (c => c.ValorVenda)) }

            ).ToListAsync ();*/
            return ew;
            //return null;
            // return _context.movimentoAcao.ToListAsync ();
            //  return Ok (JsonSerializer.Serialize (x));
            //return await _context.acao.ToListAsync();
        }

    }
}