using System;
using System.IO;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Xml;

namespace Xtime.ServiceSync
{
    /* CustomWsdlService just fetchs the WSDL from the resource table.
     * Should extend to make the URL dynamic or leave out entirely if not serving a WSDL.
     * 
     * If using this, remember to update the service address in the WSDL and rebuild.
     * 
     * 
     * */

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class CustomWsdlService : ICustomWsdl
    {
        private string renameXsd(string src)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(src);
            XmlNodeList xmlnodes = xdoc.GetElementsByTagName("xsd:include");
            updateNodes(xmlnodes);
            xmlnodes = xdoc.GetElementsByTagName("xsd:import");
            updateNodes(xmlnodes);
            return xdoc.InnerXml;
        }

        private void updateNodes(XmlNodeList xmlnodes)
        {
            for (int i = 0; i < xmlnodes.Count; i++)
            {
                string xsdName = xmlnodes[i].Attributes["schemaLocation"].Value as string;
                if (!string.IsNullOrEmpty(xsdName))
                {
                    string newName = "MetaData?name="
                      + Path.GetFileNameWithoutExtension(xsdName) + "&extension=xsd";
                    xmlnodes[i].Attributes["schemaLocation"].Value = newName;
                }
            }
        }

        public Stream wsdl()
        {
           
            return new System.IO.MemoryStream(Encoding.UTF8.GetBytes(ConsoleServiceSyncWCF.Properties.Resources.XtimeWebService));
        }
    }
}