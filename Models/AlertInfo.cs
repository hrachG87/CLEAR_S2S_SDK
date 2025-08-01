using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AlertInfo")]
public class AlertInfo
{
    [XmlElement("SSN")]
    public SSNInfo SSN { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("AlertIndicator")]
    public string AlertIndicator { get; set; }

    [XmlElement("AlertDescription")]
    public string AlertDescription { get; set; }

}