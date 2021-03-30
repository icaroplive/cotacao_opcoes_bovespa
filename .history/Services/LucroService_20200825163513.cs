using carteiraAcoes.Entity;
using carteiraAcoes.Interfaces;
using carteiraAcoes.Models;

namespace carteiraAcoes.Services {
    public class LucroService : ILucroService {
        public BancoContext _context;
        public LucroService (BancoContext context) {
            _context = context;
        }
        public Dash PegarLucroMensalAcao {
            get =>
                throw new System.NotImplementedException ();
            set =>
                throw new System.NotImplementedException ();
        }
        public Dash PegarLucroMensalOpcao {
            get =>
                throw new System.NotImplementedException ();
            set =>
                throw new System.NotImplementedException ();
        }
    }
}