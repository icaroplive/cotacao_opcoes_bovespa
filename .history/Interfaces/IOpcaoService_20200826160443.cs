using System.Threading.Tasks;
using call.Models;

namespace carteiraAcoes.Interfaces {
    public interface IOpcaoService {
        Task<resultado> pegarOpcoes (string acao);
    }
}