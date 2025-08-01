using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DateRange")]
public class DateRange
{
    [XmlElement("StartDate")]
    public string StartDate { get; set; }

    [XmlElement("EndDate")]
    public string EndDate { get; set; }
}
