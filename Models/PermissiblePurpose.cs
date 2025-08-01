using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PermissiblePurpose")]
public class PermissiblePurpose
{
    [XmlElement("GLB")]
    public string GLB { get; set; }

    [XmlElement("DPPA")]
    public string DPPA { get; set; }

    [XmlElement("VOTER")]
    public string VOTER { get; set; }
}
