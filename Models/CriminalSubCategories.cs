using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalSubCategories")]
public class CriminalSubCategories
{
    [XmlElement("FelonyVulnerableVictim")]
    public RiskFlagInfo FelonyVulnerableVictim { get; set; }

}