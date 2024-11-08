using CacaoDuarteAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CacaoDuarteAPI.DATA
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<EmpresaCompraCacao>  EmpresaCompraCacaos { get; set; }    
        public DbSet<PrecioCacao> PreciosCacaos { get; set; }
        public DbSet<TiposCacao> TiposCacaos { get; set;}

    }
}
