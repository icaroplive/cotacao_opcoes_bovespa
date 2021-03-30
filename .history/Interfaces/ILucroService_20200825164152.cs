using System.Collections.Generic;
using System.Threading.Tasks;
using carteiraAcoes.Models;

namespace carteiraAcoes.Interfaces {
    public interface ILucroService {
        public Task<IEnumerable<Dash>>  PegarLucroMensalAcao ();
        public Dash PegarLucroMensalOpcao ();

    }
}