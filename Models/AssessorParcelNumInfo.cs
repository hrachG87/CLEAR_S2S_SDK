using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AssessorParcelNumInfo")]
public class AssessorParcelNumInfo
{
    [XmlElement("AccountNumber")]
    public string AccountNumber { get; set; }

    [XmlElement("FormattedAPN")]
    public string FormattedAPN { get; set; }

    [XmlElement("HistoricAPN")]
    public string HistoricAPN { get; set; }

    [XmlElement("OriginalAPN")]
    public string OriginalAPN { get; set; }

    [XmlElement("UnformattedAPN")]
    public string UnformattedAPN { get; set; }

    [XmlElement("APNSeqNum")]
    public string APNSeqNum { get; set; }

    [XmlElement("IRISFormattedAPN")]
    public List<string> IRISFormattedAPN { get; set; }

}
}