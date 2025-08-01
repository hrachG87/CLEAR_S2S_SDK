using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformPersonReportWebAnalyticsRecordInfo")]
public class RiskInformPersonReportWebAnalyticsRecordInfo
{
    [XmlElement("RecordId")]
    public List<string> RecordId { get; set; }

}
}