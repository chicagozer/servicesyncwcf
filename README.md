servicesyncwcf
==============

Microsoft WCF stub implementation of Xtime ServiceSync DMS-S.

This project demonstrates XtimeAddCustomer and XtimeUpdateCustomer.

To run the project, you will need to allow permission to host the console service using an elevated command prompt or other means.

netsh http add urlacl url=http://+:5555/ServiceSync/ user="NT AUTHORITY\Authenticated Users"

There is a SoapUI project directory containing a client project to call the web service.

To imbed the Xtime wsdl, use svcutil or the Visual Studio "Add service reference".

Some changes were required to the reference.

  Removed action="urn:newoperation"
  
  Added DispatchBodyElement to each Operation.
  
    [DispatchBodyElement("XtimeAddCustomerElement", "http://schemas.xtime.com/webservices/01/transport")]
    
  Added DispatchByBodyElementBehavior to ServiceContract.
  
   [System.ServiceModel.ServiceContractAttribute(Namespace="http://xtime.com/webservices/01/bindings", ConfigurationName="Xtime.ServiceSync.XtimeRequest"),DispatchByBodyElementBehavior]
  
  The dispatch router helper classes are taken from Microsoft interop examples.
