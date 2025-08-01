using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EIDVBusinessSearchResponse")]
public class EIDVBusinessSearchResponse
{
    [XmlElement("Status")]
    public List<EIDVBusinessSearchResults> Status { get; set; }

}
}