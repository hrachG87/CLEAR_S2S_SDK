using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformBusinessSearchResponse")]
public class RiskInformBusinessSearchResponse
{
    [XmlElement("Status")]
    public RiskInformBusinessStatus Status { get; set; }

    [XmlElement("riskInformBusinessSearchResult")]
    public RiskInformBusinessSearchResult riskInformBusinessSearchResult { get; set; }

}
}