using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("NonDerivativeInfo")]
public class NonDerivativeInfo
{
    [XmlElement("NumberOfSharesAcquired")]
    public string NumberOfSharesAcquired { get; set; }

    [XmlElement("NumberOfSharesInTransaction")]
    public string NumberOfSharesInTransaction { get; set; }

    [XmlElement("NumberOfSharesSold")]
    public string NumberOfSharesSold { get; set; }

    [XmlElement("OptionsSold")]
    public string OptionsSold { get; set; }

    [XmlElement("ResultingSharesHeld")]
    public string ResultingSharesHeld { get; set; }

    [XmlElement("SecurityType")]
    public string SecurityType { get; set; }

    [XmlElement("SequenceNumber")]
    public string SequenceNumber { get; set; }

    [XmlElement("TransactionDate")]
    public string TransactionDate { get; set; }

    [XmlElement("TransactionType")]
    public string TransactionType { get; set; }

    [XmlElement("ItemOwnershipCategoryText")]
    public string ItemOwnershipCategoryText { get; set; }

    [XmlElement("ItemPurchasePriceValue")]
    public string ItemPurchasePriceValue { get; set; }

}
}