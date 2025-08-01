using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("GlobalBeneficialOwnershipStatus")]
public class GlobalBeneficialOwnershipStatus
{
    [XmlElement("Status")]
    public string Status { get; set; }

    [XmlElement("Date")]
    public string Date { get; set; }

}
}