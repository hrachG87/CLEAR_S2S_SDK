using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyReportInfractionSection")]
public class CompanyReportInfractionSection
{
    [XmlElement("InfractionRecord")]
    public List<CriminalRecord> InfractionRecord { get; set; }
}
