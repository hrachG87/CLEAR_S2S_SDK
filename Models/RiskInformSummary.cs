using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformSummary")]
public class RiskInformSummary
{
    [XmlElement("RiskInformSummaryRecord")]
    public RiskInformSummaryRecord RiskInformSummaryRecord { get; set; }

}
}