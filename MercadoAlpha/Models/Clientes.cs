using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoAlpha.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string nomesocial { get; set; }
        public string datanascimento { get; set; }
        public int idade { get; set; }
        public string sexo { get; set; }
        public int telefone { get; set; }
        public string email { get; set; }
        public string endereco { get; set; }
        public int cep { get; set; }
        public int cpf { get; set; }


    }
}
