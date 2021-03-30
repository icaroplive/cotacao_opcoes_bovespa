using System;
using System.ComponentModel.DataAnnotations;

namespace carteiraAcoes.Models {
    public class MovimentoOpcao {
        [Key]
        public int MovimentoOpcaoId { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorPremio { get; set; }
        public DateTime? DataVencimento { get; set; }
        public DateTime DataVenda { get; set; }
        public virtual Opcao Opcao { get; set; }
    }
}