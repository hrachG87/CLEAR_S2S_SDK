using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformScore")]
public class RiskInformScore
{
    [XmlElement("RiskInformScoreRecord")]
    public RiskInformScoreRecord RiskInformScoreRecord { get; set; }

}
}