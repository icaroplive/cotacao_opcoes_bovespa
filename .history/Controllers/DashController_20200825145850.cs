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
        public async Task<ActionResult> Getdash () {

            return _context.movimentoAcao.GroupBy (c => new { c.AcaoId, c.DataVenda }).ToListAsync ();
           /* var x = (from c in _context.movimentoAcao

                select c).ToListAsync ();
            return Ok (JsonSerializer.Serialize (x));*/
            //return await _context.acao.ToListAsync();
        }

    }
}