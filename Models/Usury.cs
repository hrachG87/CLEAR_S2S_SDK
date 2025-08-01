using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Usury")]
public class Usury
{
    [XmlElement("UsuryFlag")]
    public RiskFlagInfo UsuryFlag { get; set; }

}