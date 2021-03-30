using carteiraAcoes.Entity;
using carteiraAcoes.Interfaces;
using carteiraAcoes.Models;

namespace carteiraAcoes.Services {
    public class LucroService : ILucroService {
        public BancoContext _context;
        public LucroService (BancoContext context) {
            _context = context;
        }

        public Dash PegarLucroMensalAcao()
        {
            throw new System.NotImplementedException();
        }

        public Dash PegarLucroMensalOpcao()
        {
            throw new System.NotImplementedException();
        }
    }
}