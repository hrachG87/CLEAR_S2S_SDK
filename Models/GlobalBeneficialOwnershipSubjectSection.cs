using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("GlobalBeneficialOwnershipSubjectSection")]
public class GlobalBeneficialOwnershipSubjectSection
{
    [XmlElement("SubjectRecord")]
    public GlobalBeneficialOwnershipEntityDetail SubjectRecord { get; set; }

}
}