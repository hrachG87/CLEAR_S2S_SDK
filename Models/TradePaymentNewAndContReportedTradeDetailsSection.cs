using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("TradePaymentNewAndContReportedTradeDetailsSection")]
public class TradePaymentNewAndContReportedTradeDetailsSection
{
    [XmlElement("TradePaymentNewAndContReportedTradeDetailsRecord")]
    public List<TradePaymentNewAndContReportedTradeDetailsRecord> TradePaymentNewAndContReportedTradeDetailsRecord { get; set; }
}
