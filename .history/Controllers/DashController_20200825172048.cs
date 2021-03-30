using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using carteiraAcoes.Entity;
using carteiraAcoes.Interfaces;
using carteiraAcoes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace carteiraAcoes.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class DashController : ControllerBase {
        private readonly BancoContext _context;
        private readonly ILucroService _lucroService;

        public DashController (BancoContext context, ILucroService lucroService) {
            _context = context;
            _lucroService = lucroService;
        }

        [HttpGet]
        public async Task<IEnumerable<Dash>> GetLucroMensal () {
            return await _lucroService.PegarLucroMensalAcao ();
            //return _context.movimentoAcao.Where (c => c.Vendido == true).GroupBy (c => new { c.AcaoId, c.DataVenda }).Select (c => c).ToListAsync ();
            /* var ew = _context.movimentoAcao
                 .Where (c => c.Vendido)
                 .AsEnumerable ()
                 .GroupBy (c => new { Convert.ToDateTime (c.DataVenda).Month, Convert.ToDateTime (c.DataVenda).Year })
                 // .GroupBy (c => new { c.AcaoId , Convert.ToDateTime(c.DataVenda).Month , Convert.ToDateTime(c.DataVenda).Year })
                 .Select (c => new Dash () {
                     Quantidade = c.Sum (c => c.Quantidade),
                         Lucro = c.Sum (c => c.Quantidade * (c.ValorVenda - c.ValorCompra)),
                         DataVenda = c.Select (x => x.DataVenda).FirstOrDefault ()
                     // AcaoId = c.Key.AcaoId,
                     //Acao = c.Select(x => x.Acao).FirstOrDefault()
                 })

                 .ToList ();*/
            /*var x = await (from c in _context.movimentoAcao where c.Vendido group c by new { c.AcaoId } into grp

                select new Dash { Acao = grp., Quantidade = grp.Sum (c => c.Quantidade), Lucro = grp.Sum (c => c.Quantidade) * (grp.Sum (c => c.ValorVenda) - grp.Sum (c => c.ValorVenda)) }

            ).ToListAsync ();*/
            // return ew;
            //return null;
            // return _context.movimentoAcao.ToListAsync ();
            //  return Ok (JsonSerializer.Serialize (x));
            //return await _context.acao.ToListAsync();
        }

    }
}