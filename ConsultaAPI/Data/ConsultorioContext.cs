using ConsultaAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace ConsultaAPI.Data
{
    public class ConsultorioContext : DbContext
    {
        public ConsultorioContext(DbContextOptions<ConsultorioContext> options) 
        : base(options)
        {
        }
        public DbSet<Paciente> Pacientes { get; set; } = default!;
    }
}
