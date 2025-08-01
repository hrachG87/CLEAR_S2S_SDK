using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("EidvPermissiblePurpose")]
public class EidvPermissiblePurpose
{
    [XmlElement("DPPA")]
    public string DPPA { get; set; }

    [XmlElement("GLB")]
    public string GLB { get; set; }

    [XmlElement("VOTER")]
    public string VOTER { get; set; }
}
