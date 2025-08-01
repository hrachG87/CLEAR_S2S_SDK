using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("OdometerTampering")]
public class OdometerTampering
{
    [XmlElement("OdometerTamperingFlag")]
    public RiskFlagInfo OdometerTamperingFlag { get; set; }

}