using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessReportNewsRecord")]
public class BusinessReportNewsRecord
{
    [XmlElement("RecordId")]
    public List<string> RecordId { get; set; }

}