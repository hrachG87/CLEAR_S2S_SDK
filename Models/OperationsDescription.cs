using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("OperationsDescription")]
public class OperationsDescription
{
    [XmlElement("Description")]
    public List<string> Description { get; set; }

}