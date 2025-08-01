using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("SanctionSection")]
public class SanctionSection
{
    [XmlElement("SanctionRecord")]
    public List<SanctionRecord> SanctionRecord { get; set; }

}