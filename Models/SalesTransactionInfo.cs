using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SalesTransactionInfo")]
public class SalesTransactionInfo
{
    [XmlElement("ConstructionLoanInd")]
    public string ConstructionLoanInd { get; set; }

    [XmlElement("ConstructionTypeDesc")]
    public string ConstructionTypeDesc { get; set; }

    [XmlElement("EquityLoan")]
    public string EquityLoan { get; set; }

    [XmlElement("FirstMortgage")]
    public FirstMortgage FirstMortgage { get; set; }

    [XmlElement("ForeclosureSale")]
    public string ForeclosureSale { get; set; }

    [XmlElement("InterfamilyTransaction")]
    public string InterfamilyTransaction { get; set; }

    [XmlElement("LenderInfo")]
    public LenderInfo LenderInfo { get; set; }

    [XmlElement("MethodOfPayment")]
    public string MethodOfPayment { get; set; }

    [XmlElement("MultipleAPNCount")]
    public string MultipleAPNCount { get; set; }

    [XmlElement("MultipleAPNFlag")]
    public string MultipleAPNFlag { get; set; }

    [XmlElement("OwnerPercentXfer")]
    public string OwnerPercentXfer { get; set; }

    [XmlElement("PrivatePartyLender")]
    public string PrivatePartyLender { get; set; }

    [XmlElement("RecordingInfo")]
    public RecordingInfo RecordingInfo { get; set; }

    [XmlElement("RefinanceDescription")]
    public string RefinanceDescription { get; set; }

    [XmlElement("SaleConsideration")]
    public string SaleConsideration { get; set; }

    [XmlElement("SalePrice")]
    public string SalePrice { get; set; }

    [XmlElement("SalesCode")]
    public string SalesCode { get; set; }

    [XmlElement("SecondMortgage")]
    public SecondMortgage SecondMortgage { get; set; }

    [XmlElement("SellerCarrybackInd")]
    public string SellerCarrybackInd { get; set; }

    [XmlElement("SellerName")]
    public string SellerName { get; set; }

    [XmlElement("FormerAssociation")]
    public string FormerAssociation { get; set; }

    [XmlElement("TitleCompanyName")]
    public string TitleCompanyName { get; set; }

    [XmlElement("TransactionDate")]
    public string TransactionDate { get; set; }

    [XmlElement("TransactionDocNum")]
    public string TransactionDocNum { get; set; }

    [XmlElement("TypeOfSalesDeed")]
    public string TypeOfSalesDeed { get; set; }

    [XmlElement("TypeOfTransaction")]
    public string TypeOfTransaction { get; set; }

}
}