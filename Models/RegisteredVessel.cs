using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RegisteredVessel")]
public class RegisteredVessel
{
    [XmlElement("RegisteredGrossTons")]
    public string RegisteredGrossTons { get; set; }

    [XmlElement("RegisteredNetTons")]
    public string RegisteredNetTons { get; set; }

    [XmlElement("RegisteredLength")]
    public string RegisteredLength { get; set; }

    [XmlElement("RegisteredBreadth")]
    public string RegisteredBreadth { get; set; }

    [XmlElement("RegisteredDepth")]
    public string RegisteredDepth { get; set; }

}