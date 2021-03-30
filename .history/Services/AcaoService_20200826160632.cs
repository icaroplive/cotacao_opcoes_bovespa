using System.Threading.Tasks;
using AngleSharp;
using call.Models;

namespace call.Services {
    public class AcaoService {
        public async Task<decimal> valorAcao (string codigo) {
            var config = Configuration.Default.WithDefaultLoader ();
            var context = BrowsingContext.New (config);
            var document = await context.OpenAsync ("https://br.advfn.com/p.php?pid=quote&symbol=" + codigo);
            return decimal.Parse (document.QuerySelectorAll ("#quoteElementPiece1") [0].InnerHtml.Replace (".", ","));
        }
    }
}