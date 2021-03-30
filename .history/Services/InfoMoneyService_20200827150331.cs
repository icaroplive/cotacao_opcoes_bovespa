using System.Collections.Generic;
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
            Dictionary<string,string> parameters = new Dictionary<string,string>();
            parameters.Add ();
            throw new System.NotImplementedException ();
        }
    }
}