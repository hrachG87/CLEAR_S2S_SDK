using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalSubcategoryFraudulentActivities")]
public class CriminalSubcategoryFraudulentActivities
{
    [XmlElement("FraudFalseStatement")]
    public CriminalChargetypes FraudFalseStatement { get; set; }

    [XmlElement("FraudByWire")]
    public CriminalChargetypes FraudByWire { get; set; }

    [XmlElement("FraudComputer")]
    public CriminalChargetypes FraudComputer { get; set; }

    [XmlElement("IdentityTheft")]
    public CriminalChargetypes IdentityTheft { get; set; }

    [XmlElement("BankruptcyFraud")]
    public CriminalChargetypes BankruptcyFraud { get; set; }

    [XmlElement("SecuritiesFraud")]
    public CriminalChargetypes SecuritiesFraud { get; set; }

    [XmlElement("MortgageFraud")]
    public CriminalChargetypes MortgageFraud { get; set; }

    [XmlElement("BankFraud")]
    public CriminalChargetypes BankFraud { get; set; }

    [XmlElement("CharityFraud")]
    public CriminalChargetypes CharityFraud { get; set; }

    [XmlElement("Fraud")]
    public CriminalChargetypes Fraud { get; set; }

    [XmlElement("HealthcareFraud")]
    public CriminalChargetypes HealthcareFraud { get; set; }

    [XmlElement("InsuranceFraud")]
    public CriminalChargetypes InsuranceFraud { get; set; }

    [XmlElement("GovtFraudAttemptToDefraud")]
    public CriminalChargetypes GovtFraudAttemptToDefraud { get; set; }

    [XmlElement("PublicBenefitsFraud")]
    public CriminalChargetypes PublicBenefitsFraud { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}
}