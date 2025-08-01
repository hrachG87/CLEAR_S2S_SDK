using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ReportPermissiblePurpose")]
public class ReportPermissiblePurpose
{
    [XmlElement("GLB")]
    public string GLB { get; set; }

    [XmlElement("DPPA")]
    public string DPPA { get; set; }

    [XmlElement("VOTER")]
    public string VOTER { get; set; }

}