using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformPersonSearchResponseV3")]
public class RiskInformPersonSearchResponseV3
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("RiskInformPersonSearchResult")]
    public RiskInformPersonSearchResult RiskInformPersonSearchResult { get; set; }

}
}