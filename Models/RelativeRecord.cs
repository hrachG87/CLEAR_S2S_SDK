using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RelativeRecord")]
public class RelativeRecord
{
    [XmlElement("RelativeFirst")]
    public List<PersonRelativeInfo> RelativeFirst { get; set; }

    [XmlElement("RelativeSecond")]
    public List<PersonRelativeInfo> RelativeSecond { get; set; }

    [XmlElement("RelativeThird")]
    public List<PersonRelativeInfo> RelativeThird { get; set; }

}