using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyNames")]
public class CompanyNames
{
    [XmlElement("CompanyName")]
    public List<string> CompanyName { get; set; }
}
