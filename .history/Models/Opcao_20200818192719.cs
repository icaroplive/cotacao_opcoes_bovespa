using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carteiraAcoes.Models
{
    public class Opcao
    {
        [Key]
        public int OpcaoId { get; set; }
        public string Descricao { get; set; }
        public decimal ValorStrike { get; set; }
        public virtual Acao Acao { get; set; }
        public virtual Serie Serie { get; set; }
    }
}