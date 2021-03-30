using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
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
            parameters.Add ("cotacoes_opcoes_table_nonce", "95eb0f8961");

            var request = new HttpRequestMessage {
                RequestUri = new Uri ("https://www.infomoney.com.br/wp-admin/admin-ajax.php"),
                Method = HttpMethod.Post,
                Content = new FormUrlEncodedContent (parameters)
            };

            var result = await _cliente.SendAsync (request);

            return JsonSerializer.Deserialize<InfoMoneyResultOpcao> (result.Content.ReadAsStringAsync ().Result);

        }
    }
}