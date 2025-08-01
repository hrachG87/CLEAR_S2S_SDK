using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("WorldCheckDocumentDominantValuesContainer")]
public class WorldCheckDocumentDominantValuesContainer
{
    [XmlElement("WorldCheckDocumentDominantValues")]
    public WorldCheckDocumentDominantValues WorldCheckDocumentDominantValues { get; set; }

}