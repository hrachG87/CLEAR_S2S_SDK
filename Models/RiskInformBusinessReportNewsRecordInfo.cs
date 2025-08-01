using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformBusinessReportNewsRecordInfo")]
public class RiskInformBusinessReportNewsRecordInfo
{
    [XmlElement("RecordId")]
    public List<string> RecordId { get; set; }

}