using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("SecondarySICInfo")]
public class SecondarySICInfo
{
    [XmlElement("SecondarySIC")]
    public string SecondarySIC { get; set; }

    [XmlElement("SecondarySICDescription")]
    public string SecondarySICDescription { get; set; }

}