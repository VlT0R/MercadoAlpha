using MercadoAlpha.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoAlpha
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> option) : base(option) { }

        public DbSet<Clientes> CLIENTES { get; set; }
        public DbSet<Produtos> PRODUTOS { get; set; }
        public DbSet<Funcionario> FUNCIONARIOS { get; set; }
    }
}
