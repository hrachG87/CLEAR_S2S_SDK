using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("StolenProperty")]
public class StolenProperty
{
    [XmlElement("SaleStolenProperty")]
    public RiskFlagInfo SaleStolenProperty { get; set; }

    [XmlElement("InterstateTransportStolenProperty")]
    public RiskFlagInfo InterstateTransportStolenProperty { get; set; }

    [XmlElement("ReceiptStolenProperty")]
    public RiskFlagInfo ReceiptStolenProperty { get; set; }

    [XmlElement("PossessStolenProperty")]
    public RiskFlagInfo PossessStolenProperty { get; set; }

    [XmlElement("ConcealStolenProperty")]
    public RiskFlagInfo ConcealStolenProperty { get; set; }

    [XmlElement("StolenPropertyFlag")]
    public RiskFlagInfo StolenPropertyFlag { get; set; }

    [XmlElement("DealingInStolenProperty")]
    public RiskFlagInfo DealingInStolenProperty { get; set; }

}