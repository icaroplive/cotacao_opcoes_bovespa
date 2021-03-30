using carteiraAcoes.Models;
using Microsoft.EntityFrameworkCore;
namespace carteiraAcoes.Entity
{
    public class BancoContext: DbContext
    {
        public BancoContext (DbContextOptions<BancoContext> options) : base (options) { }
        public DbSet<Acao> acao { get; set; }
        public DbSet<Opcao> opcao { get; set; }
    }
}