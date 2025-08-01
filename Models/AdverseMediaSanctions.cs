using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaSanctions")]
public class AdverseMediaSanctions
{
    [XmlElement("AdverseMedia")]
    public bool AdverseMedia { get; set; }

    [XmlElement("Sanctions")]
    public bool Sanctions { get; set; }

    [XmlElement("PoliticallyExposedPersons")]
    public bool PoliticallyExposedPersons { get; set; }

    [XmlElement("StateOwnedEntities")]
    public bool StateOwnedEntities { get; set; }
}
