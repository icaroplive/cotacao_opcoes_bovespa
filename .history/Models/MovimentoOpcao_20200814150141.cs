using System;
using System.ComponentModel.DataAnnotations;

namespace carteiraAcoes.Models {
    public class MovimentoOpcao {
        [Key]
        public int id { get; set; }
        public int Opcaoid { get; set; }
        public int quantidade { get; set; }
        public decimal valorPremio { get; set; }
        public DateTime dataVencimento { get; set; }
        public virtual Opcao opcao { get; set; }
    }
}