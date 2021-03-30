using System.Threading.Tasks;
using AngleSharp;
using call.Models;

namespace call.Services {
    public static class AcaoService {
        public static async Task<valores> x (string codigo, int ano) {

            //var  wc = new WebClient();

            //string pagina = await wc.DownloadStringAsync("https://www.monetizeup.com.br/site/pages/Opcoes/DadosOpcoes.aspx?Codigo=PETRH232&Ano=2020");
            // Load default configuration
            var config = Configuration.Default.WithDefaultLoader ();
            // Create a new browsing context
            var context = BrowsingContext.New (config);
            // This is where the HTTP request happens, returns <IDocument> that // we can query later
            var document = await context.OpenAsync ("https://www.monetizeup.com.br/site/pages/Opcoes/DadosOpcoes.aspx?Codigo=" + codigo + "&Ano=2020");
            // Log the data to the console
            //  var advertrows = document.QuerySelectorAll ("#MainContent_lblCotVlMaximoCompraOferta")[0].InnerHtml;

            //var valor= advertrows[0].InnerHtml;
            return new valores () {
                vlrCompra = decimal.Parse (document.QuerySelectorAll ("#MainContent_lblCotVlMaximoCompraOferta") [0].InnerHtml.Replace (".", ",")),
                    vlrVenda = decimal.Parse (document.QuerySelectorAll ("#MainContent_lblCotVlMaximoVendaOferta") [0].InnerHtml.Replace (".", ","))
            };

        }
        public static async Task<decimal> valorAcao (string codigo) {
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