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
        public async Task<ActionResult<IEnumerable<MovimentoAcao>>> Getdash () {

            //return _context.movimentoAcao.Where (c => c.Vendido == true).GroupBy (c => new { c.AcaoId, c.DataVenda }).Select (c => c).ToListAsync ();
            //var x = (from c in _context.movimentoAcao group c by new { c.AcaoId, c.DataVenda } into grp select new MovimentoAcao { Quantidade = grp.Sum (c => c.Quantidade) }).ToListAsync ();
            // return x;
            //return null;
            return async _context.movimentoAcao.ToListAsync ();
            //  return Ok (JsonSerializer.Serialize (x));
            //return await _context.acao.ToListAsync();
        }

    }
}