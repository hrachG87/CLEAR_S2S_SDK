using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformPersonReportNewsRecordInfo")]
public class RiskInformPersonReportNewsRecordInfo
{
    [XmlElement("RecordId")]
    public List<string> RecordId { get; set; }

}
}