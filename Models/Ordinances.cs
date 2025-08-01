using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Ordinances")]
public class Ordinances
{
    [XmlElement("MunicipalOrdinance")]
    public RiskFlagInfo MunicipalOrdinance { get; set; }

    [XmlElement("CountyOrdinance")]
    public RiskFlagInfo CountyOrdinance { get; set; }

}