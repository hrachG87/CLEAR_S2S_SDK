using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformPersonReportNewsRecordInfo")]
public class RiskInformPersonReportNewsRecordInfo
{
    [XmlElement("RecordId")]
    public List<string> RecordId { get; set; }

}