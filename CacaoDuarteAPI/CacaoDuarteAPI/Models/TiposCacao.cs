using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CacaoDuarteAPI.Models
{
    public class TiposCacao
    {
        [Key]
     //   [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }

        public List<PrecioCacao>? PrecioCacao { get; set; } = new List<PrecioCacao> ();
    }
}
