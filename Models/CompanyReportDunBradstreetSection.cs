using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyReportDunBradstreetSection")]
public class CompanyReportDunBradstreetSection
{
    [XmlElement("DunBradstreetRecord")]
    public List<DunBradstreetRecord> DunBradstreetRecord { get; set; }
}
