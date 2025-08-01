using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformPartyToRiskBasedLawsuitsDetails")]
public class RiskInformPartyToRiskBasedLawsuitsDetails
{
    [XmlElement("PartyToRiskBasedLawsuitsRecord")]
    public BusinessRiskRecord PartyToRiskBasedLawsuitsRecord { get; set; }
}
