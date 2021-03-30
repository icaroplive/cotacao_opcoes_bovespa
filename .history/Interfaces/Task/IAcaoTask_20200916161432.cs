using System.Threading.Tasks;

namespace carteiraAcoes.Interfaces.Task {
    public interface IAcaoTask {
        Task<bool> sincronizarAcoes ();
        Task<bool> sincronizarOpcoes ();
    }
}