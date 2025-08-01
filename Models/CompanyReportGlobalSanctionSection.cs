using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyReportGlobalSanctionSection")]
public class CompanyReportGlobalSanctionSection
{
    [XmlElement("GlobalSanctionRecord")]
    public List<GlobalSanctionRecord> GlobalSanctionRecord { get; set; }
}
