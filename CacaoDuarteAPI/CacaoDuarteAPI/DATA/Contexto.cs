using CacaoDuarteAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CacaoDuarteAPI.DATA
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        DbSet<EmpresaCompraCacao>  EmpresaCompraCacaos { get; set; }    
        DbSet<PrecioCacao> PreciosCacaos { get; set; }
        DbSet<TiposCacao> TiposCacaos { get; set;}

    }
}
