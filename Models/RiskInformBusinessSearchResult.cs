using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformBusinessSearchResult")]
public class RiskInformBusinessSearchResult
{
    [XmlElement("ServiceErrors")]
    public RiskInformBusinessServiceErrors ServiceErrors { get; set; }

    [XmlElement("businessEntity")]
    public BusinessEntity businessEntity { get; set; }
}
