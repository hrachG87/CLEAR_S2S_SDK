using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CourtDominantValuesContainer")]
public class CourtDominantValuesContainer
{
    [XmlElement("CourtDominantValues")]
    public CourtDominantValues CourtDominantValues { get; set; }

}