using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyOfficerHistory")]
public class CompanyOfficerHistory
{
    [XmlElement("HistoryDescription")]
    public List<string> HistoryDescription { get; set; }
}
