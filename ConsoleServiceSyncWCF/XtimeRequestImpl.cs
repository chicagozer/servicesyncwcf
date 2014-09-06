using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xtime.ServiceSync;

namespace Xtime.ServiceSync
{
    class XtimeRequestImpl : Xtime.ServiceSync.XtimeRequest
    {
        public DmsExecuteAddCustomerRequest XtimeAddCustomer(XtimeAddCustomerRequest request)
        {

            Console.WriteLine("method:XtimeAddCustomer");
            Console.WriteLine("CustomerType:" + request.XtimeAddCustomerElement.Customer.CustomerType);
            for (int i = 0; i < request.XtimeAddCustomerElement.Customer.ItemsElementName.Length; i++)
            {
                Console.WriteLine("name:" + request.XtimeAddCustomerElement.Customer.ItemsElementName[i] + " value:" + request.XtimeAddCustomerElement.Customer.Items[i]);
            }

            DmsExecuteAddCustomerRequest reply = new DmsExecuteAddCustomerRequest();
            reply.AddCustomerElement = new AddCustomer();
            reply.AddCustomerElement.DealerCode = "DealerCodeHere";
            reply.AddCustomerElement.Item = "CustomerCodeHere";
            return reply;
        }

        public DmsExecuteCancelAppointmentRequest XtimeCancelAppointment(XtimeCancelAppointmentRequest request)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
            Console.WriteLine("Method:XtimeUpdateCustomer");
            Console.WriteLine("CustomerType:" + request.XtimeUpdateCustomerElement.Customer.CustomerType);
            for (int i = 0; i < request.XtimeUpdateCustomerElement.Customer.ItemsElementName.Length; i++)
            {
                Console.WriteLine("name:" + request.XtimeUpdateCustomerElement.Customer.ItemsElementName[i] + " value:" + request.XtimeUpdateCustomerElement.Customer.Items[i]);
            }


            DmsExecuteUpdateCustomerRequest reply = new DmsExecuteUpdateCustomerRequest();
            reply.UpdateCustomerElement = new UpdateCustomer();
            reply.UpdateCustomerElement.DealerCode = "DealerCodeHere";
            reply.UpdateCustomerElement.Item = "CustomerCodeHere";
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
            throw new NotImplementedException();
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
}
