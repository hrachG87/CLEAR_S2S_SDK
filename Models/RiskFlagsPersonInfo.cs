using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskFlagsPersonInfo")]
public class RiskFlagsPersonInfo
{
    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("DOB")]
    public List<string> DOB { get; set; }

    [XmlElement("SSN")]
    public List<string> SSN { get; set; }
}
