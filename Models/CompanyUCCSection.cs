using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyUCCSection")]
public class CompanyUCCSection
{
    [XmlElement("UCCRecord")]
    public List<UCCRecord> UCCRecord { get; set; }

    [XmlElement("UCCNYRecord")]
    public List<UCCNYRecord> UCCNYRecord { get; set; }
}
