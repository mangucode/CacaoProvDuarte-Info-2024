using System.ComponentModel.DataAnnotations;

namespace CacaoDuarteAPI.Models
{
    public class TiposCacao
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
    }
}
