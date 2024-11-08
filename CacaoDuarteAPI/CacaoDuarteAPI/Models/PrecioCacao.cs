using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CacaoDuarteAPI.Models
{
    public class PrecioCacao
    {
        [Key]
        public int Id { get; set; }
        public int IdTipoCacao { get; set; }
        public int IdEmpresaCompraCacao { get; set; }
        public DateTime Fecha { get; set; }
        [ForeignKey(nameof(IdTipoCacao))]
        public TiposCacao TiposCacao { get; set; }
        [ForeignKey(nameof(IdEmpresaCompraCacao))]
        public EmpresaCompraCacao EmpresaCompraCacao { get; set; }

    }
}
