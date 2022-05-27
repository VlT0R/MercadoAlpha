using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoAlpha.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        public string UnidadeMedida { get; set; }
        public string Marca { get; set; }
        public string Nome{ get; set; }
        public string Codigo { get; set; }
        public DateTime DataValidade { get; set; }
        public decimal Preco { get; set; }
        public int QtdEstoque { get; set; }
    }
}
