﻿
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Xml;
using System.ServiceModel.Description;

namespace Xtime.ServiceSync
{
    /* DispatchByBodyElementOperationSelector
     *
     * Determine which operation to call.
     * 
     * This only gets called if there is a default "*" action. So you will need one operation assigned to "*" in the App.config.
     * Then you can override if necessary with the dispatcher.
     * */
    class DispatchByBodyElementOperationSelector : IDispatchOperationSelector
    {
        Dictionary<XmlQualifiedName, string> dispatchDictionary;
        string defaultOperationName;

        public DispatchByBodyElementOperationSelector(Dictionary<XmlQualifiedName, string> dispatchDictionary, string defaultOperationName)
        {
            this.dispatchDictionary = dispatchDictionary;
            this.defaultOperationName = defaultOperationName;
        }

        #region IDispatchOperationSelector Members

        private Message CreateMessageCopy(Message message, XmlDictionaryReader body)
        {
            Message copy = Message.CreateMessage(message.Version, message.Headers.Action, body);
           copy.Headers.CopyHeaderFrom(message, 0);
            copy.Properties.CopyProperties(message.Properties);
            return copy;
        }

        public string SelectOperation(ref System.ServiceModel.Channels.Message message)
        {
            XmlDictionaryReader bodyReader = message.GetReaderAtBodyContents();
            XmlQualifiedName lookupQName = new XmlQualifiedName(bodyReader.LocalName, bodyReader.NamespaceURI);
            message = CreateMessageCopy(message, bodyReader);
            if (dispatchDictionary.ContainsKey(lookupQName))
            {
                return dispatchDictionary[lookupQName];
            }
            else
            {
                throw new NotImplementedException();
                //return defaultOperationName;
            }
        }

        #endregion
    }
}