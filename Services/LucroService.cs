using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using carteiraAcoes.Entity;
using carteiraAcoes.Interfaces;
using carteiraAcoes.Models;
using Microsoft.EntityFrameworkCore;

namespace carteiraAcoes.Services {
    public class LucroService : ILucroService {
        public BancoContext _context;
        public LucroService (BancoContext context) {
            _context = context;
        }

        public async Task<IEnumerable<Dash>> PegarLucroMensalAcao () {
            return await Task.FromResult (_context.movimentoAcao
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
                }).OrderBy (c => c.DataVenda).ToList ());
        }

        public async Task<IEnumerable<Dash>> PegarLucroMensalOpcao () {
            
            return await Task.FromResult ( _context.movimentoOpcao
                //.Where (c => c.finalizado)
                .AsEnumerable ()
                .GroupBy (c => new { Convert.ToDateTime (c.DataVenda).Month, Convert.ToDateTime (c.DataVenda).Year })
                // .GroupBy (c => new { c.AcaoId , Convert.ToDateTime(c.DataVenda).Month , Convert.ToDateTime(c.DataVenda).Year })
                .Select (c => new Dash () {
                    Quantidade = c.Sum (c => c.Quantidade),
                        Lucro = c.Sum (c => c.Quantidade * c.ValorPremio),
                        DataVenda = c.Select (x => x.DataVenda).FirstOrDefault ()
                    // AcaoId = c.Key.AcaoId,
                    //Acao = c.Select(x => x.Acao).FirstOrDefault()
                }).OrderBy(c => c.DataVenda).ToList ());
        }
    }
}