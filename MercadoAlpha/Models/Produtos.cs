using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoAlpha.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal UnidadeDeMedida { get; set; }
        public DateTime DataValidade { get; set; }
        public int QtdEstoque { get; set; }
    }
}
