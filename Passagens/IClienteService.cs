using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{

    [ServiceContract]
    public interface IClienteService
    {
        [WebInvoke(Method = "get")]
        [OperationContract]
        Cliente GetCliente(string nome);


        [WebInvoke(Method = "get", ResponseFormat = WebMessageFormat.Xml, UriTemplate = "Add/{nome};{cpf}")]
        [OperationContract]
        void Add(string nome, string cpf);
    }
}
