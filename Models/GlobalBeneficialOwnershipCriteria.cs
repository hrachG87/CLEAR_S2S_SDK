using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("GlobalBeneficialOwnershipCriteria")]
public class GlobalBeneficialOwnershipCriteria
{
    [XmlElement("GlobalBeneficialOwnershipSearchCriteria")]
    public GlobalBeneficialOwnershipSearchCriteria GlobalBeneficialOwnershipSearchCriteria { get; set; }

}