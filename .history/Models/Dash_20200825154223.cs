using System.ComponentModel.DataAnnotations;

namespace carteiraAcoes.Models
{
    public class Dash
    {
        public int Quantidade { get; set; }
        public decimal Lucro { get; set; }
        [ForeignKey ("acao")]
        public int AcaoId { get; set; }
        public virtual Acao Acao { get; set; }
    }
}