using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("TradePaymentAdditionalTradeDetailsSection")]
public class TradePaymentAdditionalTradeDetailsSection
{
    [XmlElement("TradePaymentAdditionalTradeDetailsRecord")]
    public List<TradePaymentAdditionalTradeDetailsRecord> TradePaymentAdditionalTradeDetailsRecord { get; set; }
}
