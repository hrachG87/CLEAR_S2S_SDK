using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AbuseOfCorpse")]
public class AbuseOfCorpse
{
    [XmlElement("AbuseOfCorpseFlag")]
    public RiskFlagInfo AbuseOfCorpseFlag { get; set; }

}