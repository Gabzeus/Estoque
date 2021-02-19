 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EstoqueV1
{
    class Categoria
    {[Key]
        public int idcategoria { get; set; }
        [MaxLength(100),Required]
        public string nome { get; set; }
    }
}
