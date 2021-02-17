using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EstoqueV1
{
    interface IConta
    {[Key]
        int Idconta { get; set; }
        [MaxLength(100), Required]
        string Login { get; set; }
        string Senha { get; set; }
        string Email { get; set; }
    }
}
