using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonReportAircraftSection")]
public class PersonReportAircraftSection
{
    [XmlElement("AircraftRecord")]
    public List<AircraftRecord> AircraftRecord { get; set; }

}