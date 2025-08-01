using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("GlobalBeneficialOwnershipIdentifier")]
public class GlobalBeneficialOwnershipIdentifier
{
    [XmlElement("ID")]
    public string ID { get; set; }

    [XmlElement("IDType")]
    public string IDType { get; set; }

}
}