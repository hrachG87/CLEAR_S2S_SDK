using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonUCCSection")]
public class PersonUCCSection
{
    [XmlElement("UCCRecord")]
    public List<UCCRecord> UCCRecord { get; set; }

    [XmlElement("UCCNYRecord")]
    public List<UCCNYRecord> UCCNYRecord { get; set; }
}
