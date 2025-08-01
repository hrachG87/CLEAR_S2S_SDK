using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("GlobalBeneficialOwnershipSummaryRecord")]
public class GlobalBeneficialOwnershipSummaryRecord
{
    [XmlElement("DegreeOfSeparation")]
    public int DegreeOfSeparation { get; set; }

    [XmlElement("RelationshipType")]
    public string RelationshipType { get; set; }

    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("NameOriginalLanguage")]
    public string NameOriginalLanguage { get; set; }

    [XmlElement("ReportedDate")]
    public string ReportedDate { get; set; }

    [XmlElement("EntityType")]
    public string EntityType { get; set; }

    [XmlElement("Identifier")]
    public List<GlobalBeneficialOwnershipIdentifier> Identifier { get; set; }

    [XmlElement("DateOfBirth")]
    public string DateOfBirth { get; set; }

    [XmlElement("RelatedToName")]
    public string RelatedToName { get; set; }

    [XmlElement("SharesOfOwnership")]
    public List<string> SharesOfOwnership { get; set; }

    [XmlElement("PEP")]
    public bool PEP { get; set; }

    [XmlElement("RiskIndicators")]
    public RiskIndicators RiskIndicators { get; set; }

    [XmlElement("ResultsTruncated")]
    public bool ResultsTruncated { get; set; }

    [XmlElement("AdditionalRelationships")]
    public List<RelationshipInfos> AdditionalRelationships { get; set; }

}
}