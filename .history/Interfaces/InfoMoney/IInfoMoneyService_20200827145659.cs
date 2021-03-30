using carteiraAcoes.Models.InfoMoney;

namespace carteiraAcoes.Interfaces.InfoMoney {
    public interface IInfoMoneyService {
        InfoMoneyResultOpcao pegarOpcoes (string codAcao);
    }
}