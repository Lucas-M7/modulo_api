using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entitys;

namespace ModuloAPI.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) // Conexão com o Banco de Dados
        {
        }

        public DbSet<Contatos> Contatos { get; set; } // Representar uma tabela através do Dbset
    }
}