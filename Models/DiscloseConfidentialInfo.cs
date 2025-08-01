using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DiscloseConfidentialInfo")]
public class DiscloseConfidentialInfo
{
    [XmlElement("DiscloseConfidentialInfo")]
    public RiskFlagInfo DiscloseConfidentialInfo { get; set; }

}