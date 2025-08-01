using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("GlobalBeneficialOwnershipRelationships")]
public class GlobalBeneficialOwnershipRelationships
{
    [XmlElement("Relationship")]
    public List<GlobalBeneficialOwnershipRelatedEntity> Relationship { get; set; }

}