using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ITCRegisteredVessel")]
public class ITCRegisteredVessel
{
    [XmlElement("ITCRegisteredGrossTons")]
    public string ITCRegisteredGrossTons { get; set; }

    [XmlElement("ITCRegisteredNetTons")]
    public string ITCRegisteredNetTons { get; set; }

    [XmlElement("ITCRegisteredLength")]
    public string ITCRegisteredLength { get; set; }

    [XmlElement("ITCRegisteredBreadth")]
    public string ITCRegisteredBreadth { get; set; }

    [XmlElement("ITCRegisteredDepth")]
    public string ITCRegisteredDepth { get; set; }
}
