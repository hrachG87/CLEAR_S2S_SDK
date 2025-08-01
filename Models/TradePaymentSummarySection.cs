using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("TradePaymentSummarySection")]
public class TradePaymentSummarySection
{
    [XmlElement("TradePaymentSummaryRecord")]
    public List<TradePaymentSummaryRecord> TradePaymentSummaryRecord { get; set; }

}
}