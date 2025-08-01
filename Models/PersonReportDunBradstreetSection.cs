using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonReportDunBradstreetSection")]
public class PersonReportDunBradstreetSection
{
    [XmlElement("DunBradstreetRecord")]
    public List<DunBradstreetRecord> DunBradstreetRecord { get; set; }
}
