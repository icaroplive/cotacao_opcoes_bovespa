using System.Collections.Generic;
using System.Threading.Tasks;
using carteiraAcoes.Models;

namespace carteiraAcoes.Interfaces {
    public interface ILucroService {
        Task<IEnumerable<Dash>>  PegarLucroMensalAcao ();
        Dash PegarLucroMensalOpcao ();

    }
}