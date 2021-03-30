using System.ComponentModel.DataAnnotations;

namespace carteiraAcoes.Models
{
    public class Serie
    {
        [Key]
        public int SerieId { get; set; }
        public string Descricao { get; set; }
        public int Mes { get; set; }
        
    }
}