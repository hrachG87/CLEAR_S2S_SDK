using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WatercraftDominantValuesContainer")]
public class WatercraftDominantValuesContainer
{
    [XmlElement("watercraftDominantValues")]
    public WatercraftDominantValues watercraftDominantValues { get; set; }
}
