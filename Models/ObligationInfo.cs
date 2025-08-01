using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ObligationInfo")]
public class ObligationInfo
{
    [XmlElement("Obligation")]
    public string Obligation { get; set; }

    [XmlElement("ObligationDescription")]
    public string ObligationDescription { get; set; }

    [XmlElement("OwedTotalAmount")]
    public string OwedTotalAmount { get; set; }

    [XmlElement("TotalObligation")]
    public string TotalObligation { get; set; }

}
}