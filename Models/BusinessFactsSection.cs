using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessFactsSection")]
public class BusinessFactsSection
{
    [XmlElement("BusinessFactsRecord")]
    public List<BusinessFactsRecord> BusinessFactsRecord { get; set; }
}
