﻿using Passagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ClienteService));

            Uri endereco = new Uri("http://localhost:8080/clientes");
            host.AddServiceEndpoint(typeof(IClienteService), new BasicHttpBinding(), endereco);
            try
            {
                host.Open();
                ExibeInformacoesServico(host);
                Console.ReadLine();
                host.Close();
            }
            catch (Exception e)
            {
                host.Abort();
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

        }

        public static void ExibeInformacoesServico(ServiceHost sh)
        {
            Console.WriteLine("{0} online", sh.Description.ServiceType);
            foreach (var item in sh.Description.Endpoints)
            {
                Console.WriteLine(item.Address);
            }
        }
    }
}
