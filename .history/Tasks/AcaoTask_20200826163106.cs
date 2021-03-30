using System.Collections.Generic;
using carteiraAcoes.Interfaces;
using carteiraAcoes.Interfaces.Task;

namespace carteiraAcoes.Tasks {

    public class AcaoTask : IAcaoTask {
        private readonly IAcaoService _acaoService;
        public AcaoTask (IAcaoService acaoService) {
            _acaoService = acaoService;

        }
        public void sincronizarAcoes () {
            var ativos = new List<string> { "PETR4" };
            foreach (var coisa in ativos) { 
var valorAcao = await WebScrapService.valorAcao (coisa);

            }

        }
    }
}