using GerenciadorProcessos.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorProcessos.Data
{
  public class BancoContext : DbContext 
  {
    public BancoContext(DbContextOptions<BancoContext> options) : base(options)
    {
    }

    public DbSet<ProcessoModel> Processos { get; set; } 
  }
}
