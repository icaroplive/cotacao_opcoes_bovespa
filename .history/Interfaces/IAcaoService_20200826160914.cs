using System.Threading.Tasks;

namespace carteiraAcoes.Interfaces {
    public interface IAcaoService {
        Task<decimal> valorAcao (string codigo);
    }
}