using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonRealPropertySection")]
public class PersonRealPropertySection
{
    [XmlElement("PropertyDeedRecord")]
    public List<PropertyDeedRecord> PropertyDeedRecord { get; set; }

    [XmlElement("PropertyTaxRecord")]
    public List<PropertyTaxRecord> PropertyTaxRecord { get; set; }
}
