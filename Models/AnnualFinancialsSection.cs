using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AnnualFinancialsSection")]
public class AnnualFinancialsSection
{
    [XmlElement("AnnualFinancialsRecord")]
    public List<AnnualFinancialsRecord> AnnualFinancialsRecord { get; set; }
}
