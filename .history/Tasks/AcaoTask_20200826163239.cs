using System.Collections.Generic;
using carteiraAcoes.Entity;
using carteiraAcoes.Interfaces;
using carteiraAcoes.Interfaces.Task;

namespace carteiraAcoes.Tasks {

    public class AcaoTask : IAcaoTask {
        private readonly IAcaoService _acaoService;
        private readonly BancoContext _context;
        public AcaoTask (IAcaoService acaoService, BancoContext context) {
            _acaoService = acaoService;
            _context = context;

        }
        public async void sincronizarAcoes () {
            var ativos = new List<string> { "PETR4" };
            foreach (var coisa in ativos) {
                var valorAcao = await _acaoService.pegarValorAcao (coisa);

            }

        }
    }
}