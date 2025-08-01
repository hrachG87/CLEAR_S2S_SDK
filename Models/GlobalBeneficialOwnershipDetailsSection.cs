using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("GlobalBeneficialOwnershipDetailsSection")]
public class GlobalBeneficialOwnershipDetailsSection
{
    [XmlElement("DetailsRecord")]
    public List<GlobalBeneficialOwnershipDetailsRecord> DetailsRecord { get; set; }
}
