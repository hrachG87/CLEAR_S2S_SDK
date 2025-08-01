using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyRealPropertySection")]
public class CompanyRealPropertySection
{
    [XmlElement("PropertyDeedRecord")]
    public List<PropertyDeedRecord> PropertyDeedRecord { get; set; }

    [XmlElement("PropertyTaxRecord")]
    public List<PropertyTaxRecord> PropertyTaxRecord { get; set; }
}
