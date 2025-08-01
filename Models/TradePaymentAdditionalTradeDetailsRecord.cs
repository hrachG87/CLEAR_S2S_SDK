using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("TradePaymentAdditionalTradeDetailsRecord")]
public class TradePaymentAdditionalTradeDetailsRecord
{
    [XmlElement("PaymentExperiencesAndAccountStatus")]
    public List<PaymentExperiencesAndAccountStatusDetails> PaymentExperiencesAndAccountStatus { get; set; }
}
