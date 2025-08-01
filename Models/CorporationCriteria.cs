using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CorporationCriteria")]
public class CorporationCriteria
{
    [XmlElement("CorporationId")]
    public string CorporationId { get; set; }

    [XmlElement("FilingNumber")]
    public string FilingNumber { get; set; }

    [XmlElement("FilingDate")]
    public string FilingDate { get; set; }

    [XmlElement("FEIN")]
    public string FEIN { get; set; }

    [XmlElement("DUNSNumber")]
    public string DUNSNumber { get; set; }

}
}