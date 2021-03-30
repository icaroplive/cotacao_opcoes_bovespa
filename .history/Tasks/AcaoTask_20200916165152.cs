using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using carteiraAcoes.Entity;
using carteiraAcoes.Interfaces;
using carteiraAcoes.Interfaces.InfoMoney;
using carteiraAcoes.Interfaces.Task;
using Microsoft.EntityFrameworkCore;

namespace carteiraAcoes.Tasks {

    public class AcaoTask : IAcaoTask {
        private readonly IAcaoService _acaoService;
        private readonly IOpcaoService _opcaoService;
        private readonly IInfoMoneyService _informoneyService;
        private readonly BancoContext _context;
        public AcaoTask (IAcaoService acaoService,
            BancoContext context,
            IOpcaoService opcaoService,
            IInfoMoneyService infoMoneyService
        ) {
            _acaoService = acaoService;
            _context = context;
            _opcaoService = opcaoService;
            _informoneyService = infoMoneyService;

        }
        public async Task<bool> sincronizarAcoes () {
            //var ativos = new List<string> { "PETR4","" };
            var ativos = _context.acao.Select (c => c.Codigo + c.Numero).ToList ();
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

        public async Task<bool> sincronizarOpcoes () {
            //var ativos = new List<string> { "PETR4","" };
            var ativos = _context.opcao.Select (c => c.acao.Codigo + c.acao.Numero + c.serie.Descricao + c.Descricao).ToList ();
            foreach (var ativo in ativos) {
                var valorAcao = await _opcaoService.pegarOpcoes (ativo);
                var update = _context.opcao.Where (c => (c.acao.Codigo + c.acao.Numero + c.serie.Descricao + c.Descricao) == ativo).FirstOrDefault ();
                if (update != null) {
                    update.ValorCompra = valorAcao.result.Where (c => c.symbol == ativo).FirstOrDefault ().vlrVenda;
                    _context.Entry (update).State = EntityState.Modified;
                    await _context.SaveChangesAsync ();
                }

            }
            return true;
        }
    }
}