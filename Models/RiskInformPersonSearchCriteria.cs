using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformPersonSearchCriteria")]
public class RiskInformPersonSearchCriteria
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
    public RIPersonSearchIncludeAdditionalSearches IncludeAdditionalSearches { get; set; }

    [XmlElement("AKAName")]
    public AKAPersonName AKAName { get; set; }

}
}