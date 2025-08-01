using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CareerInfo")]
public class CareerInfo
{
    [XmlElement("Job")]
    public List<string> Job { get; set; }

}