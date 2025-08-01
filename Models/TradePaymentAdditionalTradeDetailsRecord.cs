using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("TradePaymentAdditionalTradeDetailsRecord")]
public class TradePaymentAdditionalTradeDetailsRecord
{
    [XmlElement("PaymentExperiencesAndAccountStatus")]
    public List<PaymentExperiencesAndAccountStatusDetails> PaymentExperiencesAndAccountStatus { get; set; }

}
}