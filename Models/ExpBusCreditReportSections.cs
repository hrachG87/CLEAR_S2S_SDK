using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ExpBusCreditReportSections")]
public class ExpBusCreditReportSections
{
    [XmlElement("ReportSummarySection")]
    public ReportSummarySection ReportSummarySection { get; set; }

    [XmlElement("BusinessNameSection")]
    public BusinessNameSection BusinessNameSection { get; set; }

    [XmlElement("RiskDashboardSection")]
    public RiskDashboardSection RiskDashboardSection { get; set; }

    [XmlElement("BusinessFactsSection")]
    public BusinessFactsSection BusinessFactsSection { get; set; }

    [XmlElement("CommercialFraudShieldSection")]
    public CommercialFraudShieldSection CommercialFraudShieldSection { get; set; }

    [XmlElement("CreditRiskScoreAndLimitRecommendationSection")]
    public CreditRiskScoreAndLimitRecommendationSection CreditRiskScoreAndLimitRecommendationSection { get; set; }

    [XmlElement("PaymentAndLegalFilingsSummarySection")]
    public PaymentAndLegalFilingsSummarySection PaymentAndLegalFilingsSummarySection { get; set; }

    [XmlElement("PaymentTrendingSection")]
    public PaymentTrendingSection PaymentTrendingSection { get; set; }

    [XmlElement("CollectionExperiencesSection")]
    public CollectionExperiencesSection CollectionExperiencesSection { get; set; }

    [XmlElement("TradePaymentSummarySection")]
    public TradePaymentSummarySection TradePaymentSummarySection { get; set; }

    [XmlElement("TradePaymentNewAndContReportedTradeDetailsSection")]
    public TradePaymentNewAndContReportedTradeDetailsSection TradePaymentNewAndContReportedTradeDetailsSection { get; set; }

    [XmlElement("TradePaymentAdditionalTradeDetailsSection")]
    public TradePaymentAdditionalTradeDetailsSection TradePaymentAdditionalTradeDetailsSection { get; set; }

    [XmlElement("LegalFilingsSection")]
    public LegalFilingsSection LegalFilingsSection { get; set; }

    [XmlElement("CommercialFinanceRelationshipSection")]
    public CommercialFinanceRelationshipSection CommercialFinanceRelationshipSection { get; set; }

    [XmlElement("AdditionalBusinessFactsSection")]
    public AdditionalBusinessFactsSection AdditionalBusinessFactsSection { get; set; }

    [XmlElement("CorporateLinkageSection")]
    public CorporateLinkageSection CorporateLinkageSection { get; set; }

    [XmlElement("InquiriesSection")]
    public InquiriesSection InquiriesSection { get; set; }

    [XmlElement("UCCFilingsSummarySection")]
    public UCCFilingsSummarySection UCCFilingsSummarySection { get; set; }

}
}