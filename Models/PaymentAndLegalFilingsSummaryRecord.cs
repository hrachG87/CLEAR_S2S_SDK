using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PaymentAndLegalFilingsSummaryRecord")]
public class PaymentAndLegalFilingsSummaryRecord
{
    [XmlElement("CurrentDBT")]
    public int CurrentDBT { get; set; }

    [XmlElement("PredictedDBT")]
    public int PredictedDBT { get; set; }

    [XmlElement("PredictedDBTAsOfDate")]
    public string PredictedDBTAsOfDate { get; set; }

    [XmlElement("MonthlyAverageDBT")]
    public int MonthlyAverageDBT { get; set; }

    [XmlElement("HighestDBTPreviousSixMonths")]
    public int HighestDBTPreviousSixMonths { get; set; }

    [XmlElement("HighestDBTPreviousFiveQuarters")]
    public int HighestDBTPreviousFiveQuarters { get; set; }

    [XmlElement("PaymentTrendIndication")]
    public string PaymentTrendIndication { get; set; }

    [XmlElement("TotalTradeAndCollection")]
    public CountAndBalance TotalTradeAndCollection { get; set; }

    [XmlElement("AllTrades")]
    public CountAndBalance AllTrades { get; set; }

    [XmlElement("AllCollections")]
    public CountAndBalance AllCollections { get; set; }

    [XmlElement("ContinuousTrade")]
    public CountAndBalance ContinuousTrade { get; set; }

    [XmlElement("SixMonthLowestAccountBalance")]
    public int SixMonthLowestAccountBalance { get; set; }

    [XmlElement("SixMonthHighestAccountBalance")]
    public int SixMonthHighestAccountBalance { get; set; }

    [XmlElement("HighestCreditAmountExtended")]
    public int HighestCreditAmountExtended { get; set; }

    [XmlElement("IndustryPurchasingTerms")]
    public IndutryPurchasingTerms IndustryPurchasingTerms { get; set; }

    [XmlElement("BankruptcyCount")]
    public int BankruptcyCount { get; set; }

    [XmlElement("TaxLienFilings")]
    public int TaxLienFilings { get; set; }

    [XmlElement("JudgmentFilings")]
    public int JudgmentFilings { get; set; }

    [XmlElement("SumOfLegalFilings")]
    public int SumOfLegalFilings { get; set; }

    [XmlElement("CautionaryUCCFilings")]
    public int CautionaryUCCFilings { get; set; }

    [XmlElement("CurrentDBTComparison")]
    public string CurrentDBTComparison { get; set; }

    [XmlElement("AllIndustryDBT")]
    public int AllIndustryDBT { get; set; }

    [XmlElement("SameIndustryDBT")]
    public int SameIndustryDBT { get; set; }

    [XmlElement("IndustryPaymentComparison")]
    public string IndustryPaymentComparison { get; set; }

    [XmlElement("UCCFilings")]
    public int UCCFilings { get; set; }
}
