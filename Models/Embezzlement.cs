using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Embezzlement")]
public class Embezzlement
{
    [XmlElement("EmbezzlementBusinessProperty")]
    public RiskFlagInfo EmbezzlementBusinessProperty { get; set; }

    [XmlElement("EmbezzlementInterstateShipment")]
    public RiskFlagInfo EmbezzlementInterstateShipment { get; set; }

    [XmlElement("EmbezzlementBanking")]
    public RiskFlagInfo EmbezzlementBanking { get; set; }

    [XmlElement("EmbezzlementPublicProperty")]
    public RiskFlagInfo EmbezzlementPublicProperty { get; set; }

    [XmlElement("PostalEmbezzlement")]
    public RiskFlagInfo PostalEmbezzlement { get; set; }

    [XmlElement("EmbezzlementFlag")]
    public RiskFlagInfo EmbezzlementFlag { get; set; }

}
}