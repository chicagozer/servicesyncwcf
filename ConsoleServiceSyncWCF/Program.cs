using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Xtime.ServiceSync
{
    /* this program demonstrates a standalone WCF application that hosts HTTP and HTTPS versions of the Xtime DMS-S web service.
     * 
     * Two function are implemented: XtimeAddCustomer and XtimeUpdateCustomer
     * 
     * see http://servicesync.xtime.com for more detail.
     * 
     * */
    class Program
    {
        static void Main(string[] args)
        {

            /* we will host a http and https version */

            Uri staticUrl = new Uri("http://localhost:5555/static");
            //Create ServiceHost
            ServiceHost hoststatic = new ServiceHost(typeof(CustomWsdlService), staticUrl);
            hoststatic.Open();
            Console.WriteLine("Service is hosted @ " + staticUrl);
            //+ Setup the Service
            //Create a URI to serve as the base address
            Uri httpUrl = new Uri("http://localhost:5555/ServiceSync");
            //Create ServiceHost
            ServiceHost host = new ServiceHost(typeof(XtimeRequestImplHttp), httpUrl);
          
            host.Open();
            Console.WriteLine("Service is hosted @ " + httpUrl);
            
            Uri httpsUrl = new Uri("https://localhost:6666/ServiceSync");
            //Create ServiceHost
            ServiceHost hostssl = new ServiceHost(typeof(XtimeRequestImplHttps), httpsUrl);

            hostssl.Open();
            Console.WriteLine("Service is hosted @ " + httpsUrl);
           
            // wait for enter to quit.
            Console.ReadLine();
        }
    }
}
