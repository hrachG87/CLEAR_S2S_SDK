using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("FalseBombReport")]
public class FalseBombReport
{
    [XmlElement("FalseBombReportFlag")]
    public RiskFlagInfo FalseBombReportFlag { get; set; }

}