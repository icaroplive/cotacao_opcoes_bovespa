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
            var ativos = new List<string> { "PETR4", "GGBR4", "VALE3", "ITSA4", "CSNA3" };
        }
    }
}