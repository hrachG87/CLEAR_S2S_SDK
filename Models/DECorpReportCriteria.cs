using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DECorpReportCriteria")]
public class DECorpReportCriteria
{
    [XmlElement("GroupID")]
    public string GroupID { get; set; }
}
