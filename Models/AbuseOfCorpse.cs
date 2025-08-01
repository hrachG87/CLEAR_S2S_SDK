using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AbuseOfCorpse")]
public class AbuseOfCorpse
{
    [XmlElement("AbuseOfCorpseFlag")]
    public RiskFlagInfo AbuseOfCorpseFlag { get; set; }

}
}