namespace carteiraAcoes.Models
{
    public class Dash
    {
        public int Quantidade { get; set; }
        public decimal Lucro { get; set; }
        public virtual Acao Acao { get; set; }
    }
}