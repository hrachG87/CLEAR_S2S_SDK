using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CorporateLinkageRecord")]
public class CorporateLinkageRecord
{
    [XmlElement("UltimateParent")]
    public CorporateLinkageDetails UltimateParent { get; set; }

    [XmlElement("Branches")]
    public CorporateLinkageDetails Branches { get; set; }

    [XmlElement("Subsidiaries")]
    public CorporateLinkageDetails Subsidiaries { get; set; }

}
}