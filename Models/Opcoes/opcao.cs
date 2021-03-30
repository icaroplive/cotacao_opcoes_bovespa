using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace call.Models {
    public class resultado {
        public List<opcao> result { get; set; }
    }
    public class opcao {
        //{"symbol":"PETRH206","type":"Call","style":"A","strike_price":"23,03","expiry_date":"17\/08\/2020","volume":"4085300","volume_form":"4.085.300","change_percentage":"10,59%","url":"\/p.php?pid=quote&symbol=BOV%5EPETRH206","class":"up"}
        public string symbol { get; set; }
        public string type { get; set; }
        public string style { get; set; }
        public string strike_price { get; set; }
        public decimal vlrVenda { get; set; }
        public decimal lucro { get; set; }
        public decimal lucroExercicio { get; set; }

    }
}