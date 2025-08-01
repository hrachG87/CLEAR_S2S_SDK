using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonReportArrestSection")]
public class PersonReportArrestSection
{
    [XmlElement("ArrestRecord")]
    public List<ArrestRecord> ArrestRecord { get; set; }

}