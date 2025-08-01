using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DerivativeInfo")]
public class DerivativeInfo
{
    [XmlElement("ConversionExercisePrice")]
    public string ConversionExercisePrice { get; set; }

    [XmlElement("DerivativeType")]
    public string DerivativeType { get; set; }

    [XmlElement("ExercisedDate")]
    public string ExercisedDate { get; set; }

    [XmlElement("MarketPrice")]
    public string MarketPrice { get; set; }

    [XmlElement("NumberOfDerivativesAcquired")]
    public string NumberOfDerivativesAcquired { get; set; }

    [XmlElement("NumberOfDerivativesInTransaction")]
    public string NumberOfDerivativesInTransaction { get; set; }

    [XmlElement("NumberOfDerivativesSold")]
    public string NumberOfDerivativesSold { get; set; }

    [XmlElement("NumberOfUnderlyingShares")]
    public string NumberOfUnderlyingShares { get; set; }

    [XmlElement("ResultingDerivativesHeld")]
    public string ResultingDerivativesHeld { get; set; }

    [XmlElement("SequenceNumber")]
    public string SequenceNumber { get; set; }

    [XmlElement("TransactionCode")]
    public string TransactionCode { get; set; }

    [XmlElement("TransactionDate")]
    public string TransactionDate { get; set; }

    [XmlElement("TransactionType")]
    public string TransactionType { get; set; }

    [XmlElement("UnderlyingSecurityType")]
    public string UnderlyingSecurityType { get; set; }

    [XmlElement("ExpirationDate")]
    public string ExpirationDate { get; set; }

    [XmlElement("ItemOwnershipCategoryText")]
    public string ItemOwnershipCategoryText { get; set; }

}
}