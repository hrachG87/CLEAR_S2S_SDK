using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AnalyticalAssociation")]
public class AnalyticalAssociation
{
    [XmlElement("TypeOfAssociation")]
    public string TypeOfAssociation { get; set; }

    [XmlElement("AssociationDocument")]
    public List<FlagsSearchSources> AssociationDocument { get; set; }
}
