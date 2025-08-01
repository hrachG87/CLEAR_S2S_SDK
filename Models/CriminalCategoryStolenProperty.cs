using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalCategoryStolenProperty")]
public class CriminalCategoryStolenProperty
{
    [XmlElement("SaleStolenProperty")]
    public CriminalChargetypes SaleStolenProperty { get; set; }

    [XmlElement("InterstateTransportStolenProperty")]
    public CriminalChargetypes InterstateTransportStolenProperty { get; set; }

    [XmlElement("ReceiptStolenProperty")]
    public CriminalChargetypes ReceiptStolenProperty { get; set; }

    [XmlElement("PossessStolenProperty")]
    public CriminalChargetypes PossessStolenProperty { get; set; }

    [XmlElement("ConcealStolenProperty")]
    public CriminalChargetypes ConcealStolenProperty { get; set; }

    [XmlElement("DealingInStolenProperty")]
    public CriminalChargetypes DealingInStolenProperty { get; set; }

    [XmlElement("StolenProperty")]
    public CriminalChargetypes StolenProperty { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}
}