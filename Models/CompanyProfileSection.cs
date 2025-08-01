using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyProfileSection")]
public class CompanyProfileSection
{
    [XmlElement("CompanyProfileRecord")]
    public List<CompanyProfileRecord> CompanyProfileRecord { get; set; }
}
