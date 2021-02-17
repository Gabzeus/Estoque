using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EstoqueV1
{
    interface IProduto
    {[Key]
        int IdProduto { get; set; }
        [MaxLength(100), Required]
        string Nome { get; set; }
        string Quantidade { get; set; }
        string Categoria { get; set; }
        string Fornecedor { get; set; }
        DateTime DataEntrada { get; set; }
        DateTime DataValidade { get; set; }
        double Valor { get; set; }
        int QtdMinina { get; set; }
        int QtdMinina { get; set; }
        string Estoque { get; set; }
    }
}
