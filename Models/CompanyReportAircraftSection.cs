using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyReportAircraftSection")]
public class CompanyReportAircraftSection
{
    [XmlElement("AircraftRecord")]
    public List<AircraftRecord> AircraftRecord { get; set; }
}
