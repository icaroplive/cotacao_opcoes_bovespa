using carteiraAcoes.Models.InfoMoney;

namespace carteiraAcoes.Interfaces.InfoMoney {
    public interface IInfoMoneyService {
        Task<InfoMoneyResultOpcao> pegarOpcoes (string codAcao);
    }
}