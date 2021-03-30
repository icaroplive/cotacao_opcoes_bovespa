using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carteiraAcoes.Models {
    public class Opcao {
        [Key]
        public int OpcaoId { get; set; }
        public string Descricao { get; set; }
        public decimal ValorStrike { get; set; }
        public decimal ValorPremio { get; set; }
        [ForeignKey ("acao")]
        public int AcaoId { get; set; }
        [ForeignKey ("serie")]
        public int SerieId { get; set; }
        public virtual Acao acao { get; set; }
        public virtual Serie serie { get; set; }
    }
}