using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ExpBusCreditReportResults")]
public class ExpBusCreditReportResults
{
    [XmlElement("Status")]
    public ClearReportApiStatus Status { get; set; }

    [XmlElement("Uri")]
    public string Uri { get; set; }
}
