using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carteiraAcoes.Models {
    public class MovimentoOpcao {
        [Key]
        public int MovimentoOpcaoId { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorPremio { get; set; }
        public DateTime? DataVencimento { get; set; }
        public DateTime DataVenda { get; set; }
        public int MovimentoAcaoId { get; set; }
        public bool finalizado { get; set; }
        public bool exerceu { get; set; }
        [ForeignKey ("opcao")]
        public int OpcaoId { get; set; }
        public virtual Opcao Opcao { get; set; }
        
    }
}