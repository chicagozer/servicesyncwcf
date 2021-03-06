﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Xtime.ServiceSync
{
    /* DispatchBodyElementAttribute
     * 
     * sample code from Microsoft to dispatch based on the first XML element, not the action.
     */
    [AttributeUsage(AttributeTargets.Method)]
	sealed class DispatchBodyElementAttribute : Attribute, IOperationBehavior
	{
        XmlQualifiedName qname;
        
        public DispatchBodyElementAttribute(string name)
        {
            qname = new XmlQualifiedName(name);
        }

        public DispatchBodyElementAttribute(string name, string ns)
        {
            qname = new XmlQualifiedName(name, ns);
        }

        internal XmlQualifiedName QName
        {
            get { return qname; }
            set { qname = value; }
        }


        #region IOperationBehavior Members

        public void AddBindingParameters(OperationDescription operationDescription, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyClientBehavior(OperationDescription operationDescription, System.ServiceModel.Dispatcher.ClientOperation clientOperation)
        {
            
        }

        public void ApplyDispatchBehavior(OperationDescription operationDescription, System.ServiceModel.Dispatcher.DispatchOperation dispatchOperation)
        {
            
        }

        public void Validate(OperationDescription operationDescription)
        {
        }

        #endregion
    }
}

