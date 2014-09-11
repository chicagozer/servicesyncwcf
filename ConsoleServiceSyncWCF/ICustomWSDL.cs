using System;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Xtime.ServiceSync
{
    /* dummy interface to load a static HTML page from resource */

    [ServiceContract]
    public interface ICustomWsdl
    {
        [OperationContract]
        [WebGet]
        Stream wsdl();
    }
}