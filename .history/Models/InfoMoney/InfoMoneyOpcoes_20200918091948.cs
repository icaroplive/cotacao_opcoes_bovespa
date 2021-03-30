using System.Collections.Generic;
using Newtonsoft.Json;

namespace carteiraAcoes.Models.InfoMoney {
    public class InfoMoneyOptions {
        public string Price { get; set; }
        public string StockCode { get; set; }
        public string Symbol { get; set; }
    }
    public class InfoMoneyResultOpcao {
        public List<InfoMoneyOptions> Options { get; set; }
    }
}