using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("GlobalBeneficialOwnershipResponseDetailContainer")]
public class GlobalBeneficialOwnershipResponseDetailContainer
{
    [XmlElement("RecordId")]
    public string RecordId { get; set; }

    [XmlElement("GlobalBeneficialOwnershipResponseDetail")]
    public GlobalBeneficialOwnershipResponseDetail GlobalBeneficialOwnershipResponseDetail { get; set; }
}
