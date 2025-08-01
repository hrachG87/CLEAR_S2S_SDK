using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Patent")]
public class Patent
{
    [XmlElement("PatentNumber")]
    public string PatentNumber { get; set; }

    [XmlElement("ApplicationNumber")]
    public string ApplicationNumber { get; set; }

    [XmlElement("TitleAndAbstract")]
    public string TitleAndAbstract { get; set; }

    [XmlElement("NationalClassInfo")]
    public List<NationalClassInfo> NationalClassInfo { get; set; }

    [XmlElement("InternationalClass")]
    public string InternationalClass { get; set; }

    [XmlElement("Inventor")]
    public List<PatentPartyInfo> Inventor { get; set; }

    [XmlElement("Assignee")]
    public List<PatentPartyInfo> Assignee { get; set; }

    [XmlElement("PatentCurrentDate")]
    public string PatentCurrentDate { get; set; }

    [XmlElement("Abstract")]
    public string Abstract { get; set; }
}
