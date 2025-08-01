using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalCategory")]
public class CriminalCategory
{
    [XmlElement("value")]
    public string value { get; set; }

    [XmlElement("misdemeanorCharge")]
    public bool misdemeanorCharge { get; set; }

    [XmlElement("misdemeanorConviction")]
    public bool misdemeanorConviction { get; set; }

    [XmlElement("felonyCharge")]
    public bool felonyCharge { get; set; }

    [XmlElement("felonyConviction")]
    public bool felonyConviction { get; set; }

}