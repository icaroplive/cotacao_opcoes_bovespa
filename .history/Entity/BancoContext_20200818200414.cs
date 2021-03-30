using carteiraAcoes.Models;
using Microsoft.EntityFrameworkCore;
namespace carteiraAcoes.Entity {
    public class BancoContext : DbContext {
        public BancoContext (DbContextOptions<BancoContext> options) : base (options) { }
        public DbSet<Acao> acao { get; set; }
        public DbSet<Opcao> opcao { get; set; }
        public DbSet<Serie> serie { get; set; }
        public DbSet<MovimentoAcao> movimentoAcao { get; set; }
        public DbSet<MovimentoOpcao> movimentoOpcao { get; set; }
        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            base.OnModelCreating (modelBuilder);

            modelBuilder.Entity<Opcao> ().
            HasOne<Acao> (s => s.Acao)
                .WithOne (s => s.AcaoId);

        }
    }
}