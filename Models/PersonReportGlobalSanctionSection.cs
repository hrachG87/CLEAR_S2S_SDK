using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonReportGlobalSanctionSection")]
public class PersonReportGlobalSanctionSection
{
    [XmlElement("GlobalSanctionRecord")]
    public List<GlobalSanctionRecord> GlobalSanctionRecord { get; set; }
}
