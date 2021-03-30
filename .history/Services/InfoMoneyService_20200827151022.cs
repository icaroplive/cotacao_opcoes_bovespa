using System;
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
        public async Task<InfoMoneyResultOpcao> pegarOpcoes (string codAcao) {
            Dictionary<string, string> parameters = new Dictionary<string, string> ();
            parameters.Add ("action", "tool_cotacoes_opcoes");
            parameters.Add ("StockCode", codAcao);
            parameters.Add ("monthYear", "09/2020");
            parameters.Add ("type", "call");
            parameters.Add ("model", "europeu");
            parameters.Add ("cotacoes_opcoes_table_nonce", "4b272611f8");

            _cliente.BaseAddress = new Uri ("https://www.infomoney.com.br");

            var request = new HttpRequestMessage(HttpMethod.Post, "/wp-admin/admin-ajax.php");

            
            request.Content = new FormUrlEncodedContent(parameters);
            
            var response = await _cliente.SendAsync(request);

            throw new System.NotImplementedException ();
        }
    }
}