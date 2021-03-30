using System.ComponentModel.DataAnnotations;

namespace carteiraAcoes.Models
{
    public class Serie
    {
        [Key]
        public int id { get; set; }
        public string descricao { get; set; }
        public int mes { get; set; }
    }
}