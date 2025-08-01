using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CountInfo")]
public class CountInfo
{
    [XmlElement("Count")]
    public string Count { get; set; }

    [XmlElement("Disposition")]
    public string Disposition { get; set; }

}