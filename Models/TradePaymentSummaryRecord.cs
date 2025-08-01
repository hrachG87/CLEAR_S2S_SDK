using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("TradePaymentSummaryRecord")]
public class TradePaymentSummaryRecord
{
    [XmlElement("Continuous")]
    public TradePaymentDetails Continuous { get; set; }

    [XmlElement("NewlyReported")]
    public TradePaymentDetails NewlyReported { get; set; }

    [XmlElement("CombinedTrade")]
    public TradePaymentDetails CombinedTrade { get; set; }

    [XmlElement("Additional")]
    public TradePaymentDetails Additional { get; set; }

    [XmlElement("TotalTrade")]
    public TradePaymentDetails TotalTrade { get; set; }
}
