using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformPersonSearchResult")]
public class RiskInformPersonSearchResult
{
    [XmlElement("ServiceErrors")]
    public RiskInformPersonServiceErrors ServiceErrors { get; set; }

    [XmlElement("personEntity")]
    public PersonEntity personEntity { get; set; }
}
