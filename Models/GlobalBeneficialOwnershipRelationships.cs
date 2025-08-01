using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("GlobalBeneficialOwnershipRelationships")]
public class GlobalBeneficialOwnershipRelationships
{
    [XmlElement("Relationship")]
    public List<GlobalBeneficialOwnershipRelatedEntity> Relationship { get; set; }

}
}