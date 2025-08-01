using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("FraudulentActivities")]
public class FraudulentActivities
{
    [XmlElement("BankFraud")]
    public RiskFlagInfo BankFraud { get; set; }

    [XmlElement("FraudInsufficientFundsCheck")]
    public RiskFlagInfo FraudInsufficientFundsCheck { get; set; }

    [XmlElement("FraudCreditCards")]
    public RiskFlagInfo FraudCreditCards { get; set; }

    [XmlElement("FraudConfidenceGame")]
    public RiskFlagInfo FraudConfidenceGame { get; set; }

    [XmlElement("FraudSwindle")]
    public RiskFlagInfo FraudSwindle { get; set; }

    [XmlElement("MailFraud")]
    public RiskFlagInfo MailFraud { get; set; }

    [XmlElement("FraudFalseStatement")]
    public RiskFlagInfo FraudFalseStatement { get; set; }

    [XmlElement("FraudByWire")]
    public RiskFlagInfo FraudByWire { get; set; }

    [XmlElement("FraudComputer")]
    public RiskFlagInfo FraudComputer { get; set; }

    [XmlElement("IdentityTheft")]
    public RiskFlagInfo IdentityTheft { get; set; }

    [XmlElement("BankruptcyFraud")]
    public RiskFlagInfo BankruptcyFraud { get; set; }

    [XmlElement("HealthcareFraud")]
    public RiskFlagInfo HealthcareFraud { get; set; }

    [XmlElement("SecuritiesFraud")]
    public RiskFlagInfo SecuritiesFraud { get; set; }

    [XmlElement("MortgageFraud")]
    public RiskFlagInfo MortgageFraud { get; set; }

    [XmlElement("Fraud")]
    public RiskFlagInfo Fraud { get; set; }

    [XmlElement("GovtFraudAttemptToDefraud")]
    public RiskFlagInfo GovtFraudAttemptToDefraud { get; set; }

    [XmlElement("PublicBenefitsFraud")]
    public RiskFlagInfo PublicBenefitsFraud { get; set; }

    [XmlElement("InsuranceFraud")]
    public RiskFlagInfo InsuranceFraud { get; set; }

    [XmlElement("FraudImpersonation")]
    public RiskFlagInfo FraudImpersonation { get; set; }

    [XmlElement("CharityFraud")]
    public RiskFlagInfo CharityFraud { get; set; }

}