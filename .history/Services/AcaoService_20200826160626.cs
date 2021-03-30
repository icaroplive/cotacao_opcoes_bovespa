using System.Threading.Tasks;
using AngleSharp;
using call.Models;

namespace call.Services {
    public class AcaoService {
        public async Task<decimal> valorAcao (string codigo) {
            //https://br.advfn.com/p.php?pid=quote&symbol=petr4 
            var config = Configuration.Default.WithDefaultLoader ();
            var context = BrowsingContext.New (config);
            var document = await context.OpenAsync ("https://br.advfn.com/p.php?pid=quote&symbol=" + codigo);
            // Log the data to the console
            //  var advertrows = document.QuerySelectorAll ("#MainContent_lblCotVlMaximoCompraOferta")[0].InnerHtml;
            return decimal.Parse (document.QuerySelectorAll ("#quoteElementPiece1") [0].InnerHtml.Replace (".", ","));
        }
    }
}