using System.Collections.Generic;

namespace carteiraAcoes.Models.InfoMoney {
    public class InfoMoneyOptions {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal Price { get; set; } = 0;
        public string StockCode { get; set; }
        public string Symbol { get; set; }
    }
    public class InfoMoneyResultOpcao {
        public List<InfoMoneyOptions> Options { get; set; }
    }
}