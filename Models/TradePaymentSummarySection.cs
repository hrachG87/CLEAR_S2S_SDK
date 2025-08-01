using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("TradePaymentSummarySection")]
public class TradePaymentSummarySection
{
    [XmlElement("TradePaymentSummaryRecord")]
    public List<TradePaymentSummaryRecord> TradePaymentSummaryRecord { get; set; }

}