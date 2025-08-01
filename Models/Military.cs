using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Military")]
public class Military
{
    [XmlElement("MilitaryDesertion")]
    public RiskFlagInfo MilitaryDesertion { get; set; }

    [XmlElement("MilitaryFlag")]
    public RiskFlagInfo MilitaryFlag { get; set; }

}