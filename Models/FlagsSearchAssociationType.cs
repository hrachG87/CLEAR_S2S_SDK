using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("FlagsSearchAssociationType")]
public class FlagsSearchAssociationType
{
    [XmlElement("TypeOfAssociation")]
    public List<string> TypeOfAssociation { get; set; }
}
