using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DeathSummary")]
public class DeathSummary
{
    [XmlElement("PersonDeath")]
    public PersonProfile PersonDeath { get; set; }

    [XmlElement("SourceInfo")]
    public SourceInfo SourceInfo { get; set; }

}