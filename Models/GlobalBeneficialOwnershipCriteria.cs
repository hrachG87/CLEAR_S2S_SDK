using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("GlobalBeneficialOwnershipCriteria")]
public class GlobalBeneficialOwnershipCriteria
{
    [XmlElement("GlobalBeneficialOwnershipSearchCriteria")]
    public GlobalBeneficialOwnershipSearchCriteria GlobalBeneficialOwnershipSearchCriteria { get; set; }

}
}