using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformBusinessWebResult")]
public class RiskInformBusinessWebResult
{
    [XmlElement("RecordId")]
    public string RecordId { get; set; }

    [XmlElement("WebRecord")]
    public WebResult WebRecord { get; set; }
}
