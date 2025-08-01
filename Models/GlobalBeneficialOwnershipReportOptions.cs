using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("GlobalBeneficialOwnershipReportOptions")]
public class GlobalBeneficialOwnershipReportOptions
{
    [XmlElement("IncludeOwnedEntities")]
    public bool IncludeOwnedEntities { get; set; }

    [XmlElement("IncludePossiblyRelatedEntities")]
    public bool IncludePossiblyRelatedEntities { get; set; }

    [XmlElement("DegreeOfSeparation")]
    public int DegreeOfSeparation { get; set; }

    [XmlElement("RelationshipTypes")]
    public GlobalBeneficialOwnershipRelationshipTypes RelationshipTypes { get; set; }

}
}