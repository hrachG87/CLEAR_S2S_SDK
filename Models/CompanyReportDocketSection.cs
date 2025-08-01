using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyReportDocketSection")]
public class CompanyReportDocketSection
{
    [XmlElement("CompanyDocketRecord")]
    public List<CompanyDocketRecord> CompanyDocketRecord { get; set; }

}