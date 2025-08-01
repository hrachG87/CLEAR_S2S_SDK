using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyPreForeclosureSection")]
public class CompanyPreForeclosureSection
{
    [XmlElement("ForeclosureRecord")]
    public List<ForeclosureRecord> ForeclosureRecord { get; set; }
}
