using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformBusinessReportWebAnalyticsRecordInfo")]
public class RiskInformBusinessReportWebAnalyticsRecordInfo
{
    [XmlElement("RecordId")]
    public List<string> RecordId { get; set; }

}