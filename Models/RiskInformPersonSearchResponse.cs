using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformPersonSearchResponse")]
public class RiskInformPersonSearchResponse
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("RiskInformPersonSearchResult")]
    public RiskInformPersonSearchResult RiskInformPersonSearchResult { get; set; }

}
}