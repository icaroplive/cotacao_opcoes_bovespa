using System.ComponentModel.DataAnnotations;

namespace carteiraAcoes.Models
{
    public class Acao
    {
        [Key]
        public int AcaoId { get; set; }
        public string Descricao { get; set; }
        public string Acao { get; set; }
        public int Numero { get; set; }
    }
}