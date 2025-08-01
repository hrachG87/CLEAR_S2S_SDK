using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformBusinessSearchCriteria")]
public class RiskInformBusinessSearchCriteria
{
    [XmlElement("RiskInformDefName")]
    public string RiskInformDefName { get; set; }

    [XmlElement("RiskInformDefVersion")]
    public string RiskInformDefVersion { get; set; }

    [XmlElement("InternalID")]
    public string InternalID { get; set; }

    [XmlElement("EntityId")]
    public string EntityId { get; set; }

    [XmlElement("IncludeAdditionalSearches")]
    public RIBusinessSearchIncludeAdditionalSearches IncludeAdditionalSearches { get; set; }
}
