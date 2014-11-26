using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Xtime.ServiceSync;

namespace Xtime.ServiceSync
{
    /* XtimeRequestImpl is the main implementation
     * 
     * XtimeAddCustomer and XtimeUpdateCustomer are currently wired up.
     */
    class XtimeRequestImpl : Xtime.ServiceSync.XtimeRequest
    {
        public DmsExecuteAddCustomerRequest XtimeAddCustomer(XtimeAddCustomerRequest request)
        {

            Console.WriteLine("method:XtimeAddCustomer");

            // display the customer type
            Console.WriteLine("CustomerType:" + request.XtimeAddCustomerElement.Customer.CustomerType);
            for (int i = 0; i < request.XtimeAddCustomerElement.Customer.ItemsElementName.Length; i++)
            {
                Console.WriteLine("name:" + request.XtimeAddCustomerElement.Customer.ItemsElementName[i] + " value:" + request.XtimeAddCustomerElement.Customer.Items[i]);
            }


            // compose a reply
            DmsExecuteAddCustomerRequest reply = new DmsExecuteAddCustomerRequest();
            reply.AddCustomerElement = new AddCustomer();
            reply.AddCustomerElement.DealerCode = request.XtimeAddCustomerElement.DealerCode;
            reply.AddCustomerElement.Item = "CustomerCodeHere";
            reply.AddCustomerElement.RequestId = request.XtimeAddCustomerElement.RequestId;
            reply.AddCustomerElement.DocumentId = "DocIDHere";

            // custom headers we currently don't use, but could
            //MessageHeader header = MessageHeader.CreateHeader("To", "http://www.w3.org/2005/08/addressing", "http://bogus/to");

            //OperationContext.Current.OutgoingMessageHeaders.Add(header);
            //OperationContext.Current.OutgoingMessageHeaders.Action = "http://bogus/action";
            //OperationContext.Current.OutgoingMessageHeaders.To = new Uri("http://bogus/to");
            //OperationContext.Current.OutgoingMessageHeaders.ReplyTo = new EndpointAddress("http://bogus/to");
            //OperationContext.Current.OutgoingMessageHeaders.RelatesTo = new UniqueId();
            //OperationContext.Current.OutgoingMessageHeaders.From = new EndpointAddress("http://bogus/from");
            return reply;
        }

        public DmsExecuteCancelAppointmentRequest XtimeCancelAppointment(XtimeCancelAppointmentRequest request)
        {
            throw new NotImplementedException("Will implement later");
        }

        public DmsExecuteGetAdvisorConfigurationRequest XtimeGetAdvisorConfiguration(XtimeGetAdvisorConfigurationRequest request)
        {
            throw new NotImplementedException();
        }

        public DmsExecuteGetAppointmentsRequest XtimeGetAppointments(XtimeGetAppointmentsRequest request)
        {
            throw new NotImplementedException();
        }

        public DmsExecuteGetCustomerVehiclesRequest XtimeGetCustomerVehicles(XtimeGetCustomerVehiclesRequest request)
        {
            Console.WriteLine("method:getCustomerVehiclesRequest");
            Console.WriteLine("from:" + request.XtimeGetCustomerVehiclesDateRangeElement.FromDate);
            Console.WriteLine("to:" + request.XtimeGetCustomerVehiclesDateRangeElement.ToDate);
            Console.WriteLine("requestid:" + request.XtimeGetCustomerVehiclesDateRangeElement.RequestId);

            DmsExecuteGetCustomerVehiclesRequest reply = new DmsExecuteGetCustomerVehiclesRequest();
            reply.GetCustomerVehiclesElement = new GetCustomerVehicles();
            reply.GetCustomerVehiclesElement.RequestId = request.XtimeGetCustomerVehiclesDateRangeElement.RequestId;
            reply.GetCustomerVehiclesElement.DocumentId = "docidhere";
            reply.GetCustomerVehiclesElement.DealerCode = request.XtimeGetCustomerVehiclesDateRangeElement.DealerCode;
            return reply;
        }

        public DmsExecuteGetDealerConfigurationRequest XtimeGetDealerConfiguration(XtimeGetDealerConfigurationRequest request)
        {
            throw new NotImplementedException();
        }

        public DmsExecuteGetServiceCatalogRequest XtimeGetServiceCatalog(XtimeGetServiceCatalogRequest request)
        {
            throw new NotImplementedException();
        }

        public DmsExecuteGetServiceHistoryRequest XtimeGetServiceHistory(XtimeGetServiceHistoryRequest request)
        {
            throw new NotImplementedException();
        }

        public DmsExecuteGetVehicleSalesRequest XtimeGetVehicleSales(XtimeGetVehicleSalesRequest request)
        {
            throw new NotImplementedException();
        }

        public DmsExecuteGetVehicleMakesRequest XtimeGetVehicleMakes(XtimeGetVehicleMakesRequest request)
        {
            throw new NotImplementedException();
        }

        public DmsExecuteGetVehicleModelsRequest XtimeGetVehicleModels(XtimeGetVehicleModelsRequest request)
        {
            throw new NotImplementedException();
        }

        public DmsExecuteUpdateCustomerRequest XtimeUpdateCustomer(XtimeUpdateCustomerRequest request)
        {
            // display the xs:choice values
            Console.WriteLine("Method:XtimeUpdateCustomer");
            Console.WriteLine("CustomerType:" + request.XtimeUpdateCustomerElement.Customer.CustomerType);
            for (int i = 0; i < request.XtimeUpdateCustomerElement.Customer.ItemsElementName.Length; i++)
            {
                Console.WriteLine("name:" + request.XtimeUpdateCustomerElement.Customer.ItemsElementName[i] + " value:" + request.XtimeUpdateCustomerElement.Customer.Items[i]);
            }

            // compose a reply
            DmsExecuteUpdateCustomerRequest reply = new DmsExecuteUpdateCustomerRequest();
            reply.UpdateCustomerElement = new UpdateCustomer();
            reply.UpdateCustomerElement.DealerCode = request.XtimeUpdateCustomerElement.DealerCode;
            reply.UpdateCustomerElement.Item = "CustomerCodeHere";
            reply.UpdateCustomerElement.DocumentId = "Docidhere";
            reply.UpdateCustomerElement.RequestId = request.XtimeUpdateCustomerElement.RequestId;
            return reply;
        }

        public DmsExecuteWriteAppointmentRequest XtimeWriteAppointment(XtimeWriteAppointmentRequest request)
        {
            throw new NotImplementedException();
        }

        public DmsExecuteGetRepairOrderStatusesRequest XtimeGetRepairOrderStatuses(XtimeGetRepairOrderStatusesRequest request)
        {
            throw new NotImplementedException();
        }

        public XtimeFindCustomerResponse XtimeFindCustomer(XtimeFindCustomerRequest request)
        {
            throw new NotImplementedException();
        }

        public DmsExecuteGetPartsCatalogRequest XtimeGetPartsCatalog(XtimeGetPartsCatalogRequest request)
        {
            throw new NotImplementedException();
        }

        public DmsExecuteWriteRepairOrderRequest XtimeWriteRepairOrder(XtimeWriteRepairOrderRequest request)
        {
            DmsExecuteWriteRepairOrderRequest reply = new DmsExecuteWriteRepairOrderRequest();
            reply.WriteRepairOrderElement = new WriteRepairOrder();
            reply.WriteRepairOrderElement.DealerCode = "XYZ";
            reply.WriteRepairOrderElement.ItemsElementName = new ItemsChoiceType2[1];
            reply.WriteRepairOrderElement.ItemsElementName[0] = ItemsChoiceType2.CustomerId;
            reply.WriteRepairOrderElement.Items = new String[1];
            reply.WriteRepairOrderElement.Items[0] = "CustomerID";
           
            return reply;
        }

        public DmsExecuteGetRepairOrdersRequest XtimeGetRepairOrders(XtimeGetRepairOrdersRequest request)
        {
            throw new NotImplementedException();
        }

        public DmsExecuteGetRepairOrderRequest XtimeGetRepairOrder(XtimeGetRepairOrderRequest request)
        {
            throw new NotImplementedException();
        }
    }

    // couple of little stubs so we can have separate service entries.
    class XtimeRequestImplHttp : Xtime.ServiceSync.XtimeRequestImpl
    {

    }

    class XtimeRequestImplHttps : Xtime.ServiceSync.XtimeRequestImpl
    {

    }
}
