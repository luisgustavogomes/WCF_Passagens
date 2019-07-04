using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteService : IClienteService
    {

        private readonly ClienteDao _dao;

        public ClienteService()
        {
            _dao = new ClienteDao();
        }


        public void Add(Cliente c)
        {
            _dao.Add(c);
        }

        public Cliente GetCliente(string nome)
        {
            return _dao.GetCliente(nome);
        }
    }
}
