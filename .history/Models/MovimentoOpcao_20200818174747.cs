using System;
using System.ComponentModel.DataAnnotations;

namespace carteiraAcoes.Models {
    public class MovimentoOpcao {
        [Key]
        public int MovimentoOpcaoId { get; set; }
        public int quantidade { get; set; }
        public decimal valorPremio { get; set; }
        public DateTime? dataVencimento { get; set; }
        public DateTime dataVenda { get; set; }
        public virtual Opcao opcao { get; set; }
    }
}