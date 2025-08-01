using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ThisCompanySpecifics")]
public class ThisCompanySpecifics
{
    [XmlElement("PreviousDUNSNumber")]
    public string PreviousDUNSNumber { get; set; }

    [XmlElement("Country")]
    public string Country { get; set; }

    [XmlElement("Region")]
    public string Region { get; set; }

    [XmlElement("LegalStatus")]
    public string LegalStatus { get; set; }

    [XmlElement("OwnershipIs")]
    public string OwnershipIs { get; set; }

    [XmlElement("BusinessIsA")]
    public string BusinessIsA { get; set; }

    [XmlElement("DUNSNumber")]
    public string DUNSNumber { get; set; }

}
}