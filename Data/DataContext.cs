using Microsoft.EntityFrameworkCore;

namespace FIAP_MVC.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> MVC_Users { get; set; } //aqui é a criação da nossa tabela, se quisermos criar mais era só fazer mais linhas dessa e referenciar com a model
        public DbSet<Spell>MVC_Spells { get; set; }
    }
}

//aqui é onde herdamos tudo oq é nescessario para fazer conexão com o banco, criação de tabelas, adição de propriedades e td mais