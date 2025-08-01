using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonReportBusinessContactRecordsSection")]
public class PersonReportBusinessContactRecordsSection
{
    [XmlElement("BusinessContactRecord")]
    public List<BusinessContactRecord> BusinessContactRecord { get; set; }
}
