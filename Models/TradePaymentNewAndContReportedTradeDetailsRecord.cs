using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("TradePaymentNewAndContReportedTradeDetailsRecord")]
public class TradePaymentNewAndContReportedTradeDetailsRecord
{
    [XmlElement("PaymentExperiencesAndAccountStatus")]
    public List<PaymentExperiencesAndAccountStatusDetails> PaymentExperiencesAndAccountStatus { get; set; }

}
}