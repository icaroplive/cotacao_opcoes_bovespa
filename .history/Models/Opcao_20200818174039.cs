using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carteiraAcoes.Models
{
    public class Opcao
    {
        [Key]
        public int id { get; set; }
        public int Acaoid { get; set; }
        public string descricao { get; set; }
        public decimal valorStrike { get; set; }
        public int Serieid { get; set; }
        public Acao acao { get; set; }
        public Serie serie { get; set; }
    }
}