using System;

namespace Xtime.ServiceSync
{
    [ServiceContract]
    public interface ICustomWsdl
    {
        [OperationContract]
        [WebGet()]
        Stream MetaData(string name, string extension);
    }
}