using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RelationshipInfos")]
public class RelationshipInfos
{
    [XmlElement("RelationshipType")]
    public string RelationshipType { get; set; }

    [XmlElement("RelationshipDate")]
    public string RelationshipDate { get; set; }

    [XmlElement("RelationshipTypeDirectional")]
    public string RelationshipTypeDirectional { get; set; }

    [XmlElement("Former")]
    public string Former { get; set; }

}