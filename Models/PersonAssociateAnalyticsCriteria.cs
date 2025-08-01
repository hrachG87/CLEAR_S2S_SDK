using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonAssociateAnalyticsCriteria")]
public class PersonAssociateAnalyticsCriteria
{
    [XmlElement("EntityId")]
    public string EntityId { get; set; }

    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("RelativesSectionIncludeAkasOption")]
    public bool RelativesSectionIncludeAkasOption { get; set; }

    [XmlElement("RelativesMinimumStrengthOfAssociation")]
    public int RelativesMinimumStrengthOfAssociation { get; set; }

    [XmlElement("personRiskFlags")]
    public PersonAssociateRiskFlags personRiskFlags { get; set; }

    [XmlElement("personRiskFlagsSearchOptions")]
    public PersonRiskFlagsSearchOptions personRiskFlagsSearchOptions { get; set; }

}
}