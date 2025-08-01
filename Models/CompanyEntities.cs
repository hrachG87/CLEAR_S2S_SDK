using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyEntities")]
public class CompanyEntities
{
    [XmlElement("CompanyEntity")]
    public List<CompanyEntity> CompanyEntity { get; set; }
}
