using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CourtUserCriteria")]
public class CourtUserCriteria
{
    [XmlElement("CourtCriteria")]
    public CourtCriteria CourtCriteria { get; set; }

}