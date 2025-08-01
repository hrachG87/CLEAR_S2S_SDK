using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonDocumentDominantValuesContainer")]
public class PersonDocumentDominantValuesContainer
{
    [XmlElement("PersonDocumentDominantValues")]
    public PersonDocumentDominantValues PersonDocumentDominantValues { get; set; }
}
