using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carteiraAcoes.Models
{
    public class LucroMensal {
        public Dash acoes { get; set; }
        public Dash opcoes { get; set; }
    }
    public class Dash
    {
        public int Quantidade { get; set; }
        public decimal Lucro { get; set; }
        public DateTime? DataVenda { get; set; }
        [ForeignKey ("Acao")]
        public int AcaoId { get; set; }
        public virtual Acao Acao { get; set; }
    }
}