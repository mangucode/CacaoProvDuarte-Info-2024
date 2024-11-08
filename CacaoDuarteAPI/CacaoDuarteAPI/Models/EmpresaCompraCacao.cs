using System.ComponentModel.DataAnnotations;

namespace CacaoDuarteAPI.Models
{
    public class EmpresaCompraCacao
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Ubicacion { get; set; }
        public string? PaginaWeb { get; set; }

    }
}
