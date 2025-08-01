using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("FacilitateCrime")]
public class FacilitateCrime
{
    [XmlElement("FacilitateCrimeFLag")]
    public RiskFlagInfo FacilitateCrimeFLag { get; set; }
}
