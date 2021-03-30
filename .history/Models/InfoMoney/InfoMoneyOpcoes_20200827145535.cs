using System.Collections.Generic;

namespace carteiraAcoes.Models.InfoMoney
{
    public class InfoMoneyOptions
   {
       public decimal Price { get; set; }
       public string StockCode { get; set; }
       public string Symbol { get; set; }
    }
    public class InfoMoneyResultOpcao {
        public List<InfoMoneyOptions> Options { get; set; }
    }
}