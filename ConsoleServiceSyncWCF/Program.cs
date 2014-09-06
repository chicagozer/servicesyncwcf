using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Xtime.ServiceSync
{
    class Program
    {
        static void Main(string[] args)
        {
            //+ Setup the Service
            //Create a URI to serve as the base address
            Uri httpUrl = new Uri("http://localhost:5555/ServiceSync");
            //Create ServiceHost
            ServiceHost host = new ServiceHost(typeof(XtimeRequestImpl), httpUrl);
            //Add a service endpoint
            //host.AddServiceEndpoint(typeof(ConsoleApplication2.ServiceReference1.starTransportPortTypes), new WSHttpBinding(), "");
            //Enable metadata exchange
            //ServiceMetadataBehavior serviceMetadataBehavior =  
            //     new ServiceMetadataBehavior {HttpGetEnabled = true};
            // host.Description.Behaviors.Add(serviceMetadataBehavior);

            //! Turn on Debug.  Remove for production!
            // host.Description.Behaviors.Remove(typeof(ServiceDebugBehavior));
            // ServiceDebugBehavior serviceDebugBehavior =
            //     new ServiceDebugBehavior { IncludeExceptionDetailInFaults = true };
            // host.Description.Behaviors.Add(serviceDebugBehavior);

            //Start the Service
            host.Open();
            Console.WriteLine("Service is hosted @ " + httpUrl);
            Console.ReadLine();
        }
    }
}
