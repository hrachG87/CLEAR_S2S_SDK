using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("InterestInfo")]
public class InterestInfo
{
    [XmlElement("Value")]
    public string Value { get; set; }

    [XmlElement("Category")]
    public string Category { get; set; }

}