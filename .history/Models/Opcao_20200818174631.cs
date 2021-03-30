using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carteiraAcoes.Models
{
    public class Opcao
    {
        [Key]
        public int OpcaoDd { get; set; }
        public int AcaoId { get; set; }
        public string Descricao { get; set; }
        public decimal ValorStrike { get; set; }
        public Acao acao { get; set; }
        public Serie serie { get; set; }
    }
}