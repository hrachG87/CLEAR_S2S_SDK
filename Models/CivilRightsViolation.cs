using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CivilRightsViolation")]
public class CivilRightsViolation
{
    [XmlElement("CivilRights")]
    public RiskFlagInfo CivilRights { get; set; }

}