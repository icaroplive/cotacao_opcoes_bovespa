using System.ComponentModel.DataAnnotations;

namespace carteiraAcoes.Models
{
    public class Acao
    {
        [Key]
        public int id { get; set; }
        public string descricao { get; set; }
        public string acao { get; set; }
        public int numero { get; set; }
    }
}