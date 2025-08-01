using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CorporateLinkageSection")]
public class CorporateLinkageSection
{
    [XmlElement("CorporateLinkageRecord")]
    public List<CorporateLinkageRecord> CorporateLinkageRecord { get; set; }

}
}