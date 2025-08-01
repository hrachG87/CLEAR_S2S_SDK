using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonUCCFilings")]
public class PersonUCCFilings
{
    [XmlElement("UCCFilingsFlag")]
    public RiskFlagInfo UCCFilingsFlag { get; set; }

}
}