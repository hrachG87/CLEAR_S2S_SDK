using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("MarriageDivorceSummary")]
public class MarriageDivorceSummary
{
    [XmlElement("MarriageInfo")]
    public List<PersonSummaryInfo> MarriageInfo { get; set; }

    [XmlElement("DivorceInfo")]
    public List<PersonSummaryInfo> DivorceInfo { get; set; }

}
}