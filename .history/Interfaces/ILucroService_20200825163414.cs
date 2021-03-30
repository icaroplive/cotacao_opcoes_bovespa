using carteiraAcoes.Models;

namespace carteiraAcoes.Interfaces
{
    public interface ILucroService
    {
        public Dash PegarLucroMensalAcao { get; set; }
        public Dash PegarLucroMensalOpcao { get; set; }
        
    }
}