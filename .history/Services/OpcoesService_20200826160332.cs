using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using call.Models;

namespace call.Services {
    public class OpcoesService {
        public async Task<resultado> pegarOpcoes (string acao) {
            HttpClient client = new HttpClient ();
            var stringJson = await client.GetAsync("https://br.advfn.com/common/bov-options/api?symbol="+ acao +"&type=C&expiry_date=2020-09");
            var result = await stringJson.Content.ReadAsStreamAsync();
            var x = await JsonSerializer.DeserializeAsync<resultado> (result);
            return x;

        }

    }
}