using System;
using System.ComponentModel.DataAnnotations;

namespace carteiraAcoes.Models
{
    public class MovimentoOpcao
    {
        [Key]
        public int id { get; set; }
        public int Opcaoid { get; set; }
        public decimal valorPremio { get; set; }
        public decimal valorStrike { get; set; }
        public DateTime dataVencimento { get; set; }
    }
}