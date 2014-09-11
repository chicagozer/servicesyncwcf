using System;

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

    public Stream MetaData(string name, string extension)
    {
        string path =
           Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        string src =
           renameXsd(File.ReadAllText(path + "\\" + name + "." + extension));
        return new System.IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(src));
    }
}
