using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyReportCorporateSection")]
public class CompanyReportCorporateSection
{
    [XmlElement("CorporateRecord")]
    public List<CorporateRecord> CorporateRecord { get; set; }
}
