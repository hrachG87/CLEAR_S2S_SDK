using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("SECFilingSection")]
public class SECFilingSection
{
    [XmlElement("SECFilingRecord")]
    public List<SECFilingRecord> SECFilingRecord { get; set; }
}
