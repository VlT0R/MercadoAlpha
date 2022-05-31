using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoAlpha.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string nomesocial { get; set; }
        public string cargo { get; set; }
        public DateTime datanasc { get; set; }
        public string sexo { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string  email{ get; set; }
        public string rg { get; set; }
        public string cep { get; set; }
        public string cpf { get; set; }
    }
}
