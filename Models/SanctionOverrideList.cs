using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("SanctionOverrideList")]
public class SanctionOverrideList
{
    [XmlElement("Override")]
    public List<SanctionOverride> Override { get; set; }

    [XmlElement("defaultAction")]
    public string defaultAction { get; set; }
}
