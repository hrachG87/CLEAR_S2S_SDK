using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("SubSection")]
public class SubSection
{
    [XmlElement("SubSectionName")]
    public string SubSectionName { get; set; }

    [XmlElement("subSectionDetails")]
    public SubSectionDetails subSectionDetails { get; set; }

}