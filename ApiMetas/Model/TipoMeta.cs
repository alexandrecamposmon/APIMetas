using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMetas.Model
{
    public class TipoMeta
    {
        [Key]
        public Guid Id { get; set; }
        public string CDSTipoMeta { get; set; }
        public string Descricao { get; set; }
    }
}
