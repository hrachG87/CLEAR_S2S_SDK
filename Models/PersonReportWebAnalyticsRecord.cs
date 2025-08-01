using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonReportWebAnalyticsRecord")]
public class PersonReportWebAnalyticsRecord
{
    [XmlElement("RecordId")]
    public List<string> RecordId { get; set; }

}