using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carteiraAcoes.Models
{
    public class Opcao
    {
        [Key]
        public int id { get; set; }
        [ForeignKey ("acao")]
        public int Acaoid { get; set; }
        public string descricao { get; set; }
        public decimal valorStrike { get; set; }
        public int Serieid { get; set; }
        public virtual Acao acao { get; set; }
        public virtual Serie serie { get; set; }
    }
}