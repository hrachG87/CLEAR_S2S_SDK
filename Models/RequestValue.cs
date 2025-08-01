using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RequestValue")]
public class RequestValue
{
    [XmlElement("value")]
    public string value { get; set; }

    [XmlElement("name")]
    public string name { get; set; }

}