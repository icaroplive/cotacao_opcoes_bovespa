using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using carteiraAcoes.Entity;
using carteiraAcoes.Interfaces;
using carteiraAcoes.Interfaces.Task;
using Microsoft.EntityFrameworkCore;

namespace carteiraAcoes.Tasks {

    public class AcaoTask : IAcaoTask {
        private readonly IAcaoService _acaoService;
        private readonly BancoContext _context;
        public AcaoTask (IAcaoService acaoService, BancoContext context) {
            _acaoService = acaoService;
            _context = context;

        }
        public async Task<bool> sincronizarAcoes () {
            var ativos = new List<string> { "PETR4" };
            foreach (var ativo in ativos) {
                var valorAcao = await _acaoService.pegarValorAcao (ativo);
                var update = _context.acao.Where (c => (c.Codigo + c.Numero) == ativo).FirstOrDefault ();
                if (update != null) {
                    update.ValorCompra = valorAcao;
                    _context.Entry (update).State = EntityState.Modified;
                    await _context.SaveChangesAsync ();
                }
               
                

            }
            return true;
        }
    }
}