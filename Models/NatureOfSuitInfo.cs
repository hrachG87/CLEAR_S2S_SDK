using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("NatureOfSuitInfo")]
public class NatureOfSuitInfo
{
    [XmlElement("NatureOfSuit")]
    public string NatureOfSuit { get; set; }

    [XmlElement("NatureOfSuitCode")]
    public string NatureOfSuitCode { get; set; }
}
