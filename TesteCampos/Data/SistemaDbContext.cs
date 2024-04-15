using TesteCampos.Models;
using Microsoft.EntityFrameworkCore;


namespace Biblioteca.Data
{
    public class SistemaDbContext : DbContext
    {
        public SistemaDbContext() { }
        public SistemaDbContext(DbContextOptions<SistemaDbContext> options) : base(options)
        {

        }

        public DbSet<ClienteModel> tbcliente { get; set; }
        public DbSet<ProdutoModel> tbproduto { get; set; }
        public DbSet<VendaModel> tbvenda { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definindo chave primária para ClienteModel
            modelBuilder.Entity<ClienteModel>().HasKey(c => c.idCliente);

            // Definindo chave primária para ProdutoModel
            modelBuilder.Entity<ProdutoModel>().HasKey(p => p.idProduto);

            // Definindo chave primária para VendaModel
            modelBuilder.Entity<VendaModel>().HasKey(v => v.idVenda);
        }

    }
}
