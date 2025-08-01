using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("GeneralSection")]
public class GeneralSection
{
    [XmlElement("GeneralInfoRecord")]
    public List<GeneralInfoRecord> GeneralInfoRecord { get; set; }
}
