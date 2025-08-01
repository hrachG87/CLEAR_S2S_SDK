using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ElectionLaws")]
public class ElectionLaws
{
    [XmlElement("ElectionLawsFlag")]
    public RiskFlagInfo ElectionLawsFlag { get; set; }
}
