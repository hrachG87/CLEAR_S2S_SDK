using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ActualVsPeers")]
public class ActualVsPeers
{
    [XmlElement("CompareDataTable")]
    public List<CompareDataTable> CompareDataTable { get; set; }

}