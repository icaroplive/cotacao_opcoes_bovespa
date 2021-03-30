using System.Threading.Tasks;
using AngleSharp;
using call.Models;
using carteiraAcoes.Interfaces;

namespace carteiraAcoes.Services {
    public class AcaoService : IAcaoService {
        public async Task<decimal> pegarValorAcao (string codigo) {
            var config = Configuration.Default.WithDefaultLoader ();
            var context = BrowsingContext.New (config);
            //var document = await context.OpenAsync ("https://br.advfn.com/p.php?pid=quote&symbol=" + codigo);
            //return decimal.Parse (document.QuerySelectorAll ("#quoteElementPiece1") [0].InnerHtml.Replace (".", ","));
            var document = await context.OpenAsync ("https://statusinvest.com.br/acoes/" + codigo);
            return decimal.Parse (document.QuerySelectorAll ("js-symbol-last") [0].InnerHtml.Replace (".", ","));
        }
    }
}