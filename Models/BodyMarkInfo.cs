using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BodyMarkInfo")]
public class BodyMarkInfo
{
    [XmlElement("BodyMarkings")]
    public List<PersonProfile> BodyMarkings { get; set; }

}