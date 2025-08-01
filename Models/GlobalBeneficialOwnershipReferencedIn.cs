using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("GlobalBeneficialOwnershipReferencedIn")]
public class GlobalBeneficialOwnershipReferencedIn
{
    [XmlElement("SourceDocuments")]
    public List<SourceDocuments> SourceDocuments { get; set; }

}
}