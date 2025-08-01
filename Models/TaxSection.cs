using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("TaxSection")]
public class TaxSection
{
    [XmlElement("TaxInfoRecord")]
    public List<TaxInfoRecord> TaxInfoRecord { get; set; }
}
