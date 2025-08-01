using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformPartyToRiskBasedLawsuitsDetails")]
public class RiskInformPartyToRiskBasedLawsuitsDetails
{
    [XmlElement("PartyToRiskBasedLawsuitsRecord")]
    public BusinessRiskRecord PartyToRiskBasedLawsuitsRecord { get; set; }

}
}