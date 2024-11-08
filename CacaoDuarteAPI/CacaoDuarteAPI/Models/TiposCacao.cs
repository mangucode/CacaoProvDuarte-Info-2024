using System.ComponentModel.DataAnnotations;

namespace CacaoDuarteAPI.Models
{
    public class TiposCacao
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }

        public List<PrecioCacao>? PrecioCacao { get; set; } = new List<PrecioCacao> ();
    }
}
