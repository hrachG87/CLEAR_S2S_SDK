using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("GlobalBeneficialOwnershipSourceDocumentsSection")]
public class GlobalBeneficialOwnershipSourceDocumentsSection
{
    [XmlElement("SourceDocumentRecord")]
    public List<GlobalBeneficialOwnershipSourceDocumentsRecord> SourceDocumentRecord { get; set; }

}
}