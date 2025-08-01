using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("GlobalBeneficialOwnershipIdentifier")]
public class GlobalBeneficialOwnershipIdentifier
{
    [XmlElement("ID")]
    public string ID { get; set; }

    [XmlElement("IDType")]
    public string IDType { get; set; }
}
