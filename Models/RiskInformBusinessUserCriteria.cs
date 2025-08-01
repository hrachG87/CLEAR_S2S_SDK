using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformBusinessUserCriteria")]
public class RiskInformBusinessUserCriteria
{
    [XmlElement("RiskInformBusinessSearchCriteria")]
    public RiskInformBusinessSearchCriteria RiskInformBusinessSearchCriteria { get; set; }
}
