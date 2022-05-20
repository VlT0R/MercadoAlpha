using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoAlpha.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string cargo { get; set; }
        public DateTime datanasc { get; set; }
        public string sexo { get; set; }
        public char endereco { get; set; }
        public string telefone { get; set; }
        public string  email{ get; set; }


    }
}
