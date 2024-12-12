using System.Data.Entity;

namespace CamadaDeDados
{
    public class FuncionarioDBContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
        public FuncionarioDBContext() : base("DBCS") { }
    }
}
