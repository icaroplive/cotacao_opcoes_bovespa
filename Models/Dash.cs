using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carteiraAcoes.Models
{
    public class LucroMensal {
        public IEnumerable<Dash> acoes { get; set; }
        public IEnumerable<Dash> opcoes { get; set; }
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