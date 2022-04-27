using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Cliente
    {
        public string Nome { get; set; }

        public List<Cliente> Clientes(string cliente)
        {
            // new Database.Cliente().clientes();
            var clientes = new List<Cliente>
            {
                new Cliente() { Nome = "Ricardo" }
            };
            return clientes;
        }
    }
}