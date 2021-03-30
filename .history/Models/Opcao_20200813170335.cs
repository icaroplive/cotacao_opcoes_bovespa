using System.ComponentModel.DataAnnotations;

namespace carteiraAcoes.Models
{
    public class Opcao
    {
        [Key]
        public int id { get; set; }
        public string descricao { get; set; }
        public decimal valorStrike { get; set; }
    }
}