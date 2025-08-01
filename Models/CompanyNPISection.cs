using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyNPISection")]
public class CompanyNPISection
{
    [XmlElement("NPIRecord")]
    public List<NPIRecord> NPIRecord { get; set; }
}
