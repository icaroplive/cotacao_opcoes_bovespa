using System.Threading.Tasks;

namespace carteiraAcoes.Interfaces.Task {
    public interface IAcaoTask {
        Task<decimal> sincronizarAcoes ();
    }
}