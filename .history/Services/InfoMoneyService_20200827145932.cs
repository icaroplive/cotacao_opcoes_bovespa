using System.Net.Http;
using carteiraAcoes.Interfaces.InfoMoney;
using carteiraAcoes.Models.InfoMoney;

namespace carteiraAcoes.Services {
    public class InfoMoneyService : IInfoMoneyService {
        private HttpClient _cliente;
        public InfoMoneyService () {
            _cliente = new HttpClient ();
        }
        public InfoMoneyResultOpcao pegarOpcoes (string codAcao) {
            throw new System.NotImplementedException ();
        }
    }
}