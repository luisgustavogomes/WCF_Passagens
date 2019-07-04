using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Cpf { get; set; }

    }

    public class ClienteDao
    {
        private static List<Cliente> _clientes = new List<Cliente>();

        
        public void Add(Cliente c)
        {
            ClienteDao._clientes.Add(c);
        }

        public Cliente GetCliente (string nome)
        {
            return ClienteDao._clientes.Where(c => c.Nome.Equals(nome)).FirstOrDefault();
        }

    }
}
