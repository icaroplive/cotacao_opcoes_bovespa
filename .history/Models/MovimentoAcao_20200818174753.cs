using System;
using System.ComponentModel.DataAnnotations;

namespace carteiraAcoes.Models
{
    public class MovimentoAcao
    {
        [Key]
        public int MovimentoAcaoId { get; set; }
        public int quantidade { get; set; }
        public DateTime dataCompra { get; set; }
        public DateTime? dataVenda { get; set; }
        public decimal valorCompra { get; set; }
        public decimal valorVenda { get; set; }
        public virtual Acao acao { get; set; }
    }
}