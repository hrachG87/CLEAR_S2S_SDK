using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyReportArrestSection")]
public class CompanyReportArrestSection
{
    [XmlElement("ArrestRecord")]
    public List<ArrestRecord> ArrestRecord { get; set; }

}