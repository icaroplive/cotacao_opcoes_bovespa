using System;
using System.ComponentModel.DataAnnotations;

namespace carteiraAcoes.Models
{
    public class MovimentoAcao
    {
        [Key]
        public int MovimentoAcaoId { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCompra { get; set; }
        public DateTime? DataVenda { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorVenda { get; set; }
        public virtual Acao Acao { get; set; }
    }
}