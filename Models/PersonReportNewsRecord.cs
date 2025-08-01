using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonReportNewsRecord")]
public class PersonReportNewsRecord
{
    [XmlElement("RecordId")]
    public List<string> RecordId { get; set; }

}