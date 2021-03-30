using System.Threading.Tasks;

namespace carteiraAcoes.Interfaces {
    public interface IAcaoService {
        Task<decimal> pegarValorAcao (string codigo);
    }
}