using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RIPersonReportCustomDetails")]
public class RIPersonReportCustomDetails
{
    [XmlElement("customRecord")]
    public CriminalRecordInfo customRecord { get; set; }
}
