using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskFlagsMilitaryIDInfo")]
public class RiskFlagsMilitaryIDInfo
{
    [XmlElement("MilitaryID")]
    public string MilitaryID { get; set; }

    [XmlElement("LastReportedDate")]
    public string LastReportedDate { get; set; }

    [XmlElement("DocumentIdentifierInfo")]
    public RiskFlagsDocumentIdentifierInfo DocumentIdentifierInfo { get; set; }

}
}