using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("GlobalBeneficialOwnershipDetailsRecord")]
public class GlobalBeneficialOwnershipDetailsRecord
{
    [XmlElement("DegreeOfSeparation")]
    public int DegreeOfSeparation { get; set; }

    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("EntityType")]
    public string EntityType { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("Position")]
    public string Position { get; set; }

    [XmlElement("PositionOriginalLanguage")]
    public string PositionOriginalLanguage { get; set; }

    [XmlElement("Phone")]
    public string Phone { get; set; }

    [XmlElement("Identifier")]
    public List<GlobalBeneficialOwnershipIdentifier> Identifier { get; set; }

    [XmlElement("DateOfBirth")]
    public string DateOfBirth { get; set; }

    [XmlElement("NumberOfSharesOwned")]
    public List<NumberOfSharesOwned> NumberOfSharesOwned { get; set; }

    [XmlElement("PercentageOfOwnership")]
    public List<string> PercentageOfOwnership { get; set; }

    [XmlElement("ShareValue")]
    public string ShareValue { get; set; }

    [XmlElement("RelationshipType")]
    public string RelationshipType { get; set; }

    [XmlElement("RelationshipTypeDirectional")]
    public string RelationshipTypeDirectional { get; set; }

    [XmlElement("RelatedEntityName")]
    public string RelatedEntityName { get; set; }

    [XmlElement("RiskIndicators")]
    public RiskIndicators RiskIndicators { get; set; }

    [XmlElement("AdditionalRelationships")]
    public List<RelationshipInfos> AdditionalRelationships { get; set; }

}
}