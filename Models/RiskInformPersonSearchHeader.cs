using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformPersonSearchHeader")]
public class RiskInformPersonSearchHeader
{
    [XmlElement("AllFlags")]
    public RIPersonSearchHeaderDetails AllFlags { get; set; }

    [XmlElement("AddressFlags")]
    public RIPersonSearchHeaderDetails AddressFlags { get; set; }

    [XmlElement("SyntheticIdentity")]
    public RIPersonSearchHeaderDetails SyntheticIdentity { get; set; }

    [XmlElement("SingleRiskIndicators")]
    public RIPersonSearchHeaderDetails SingleRiskIndicators { get; set; }

    [XmlElement("FinancialCrimes")]
    public RIPersonSearchHeaderDetails FinancialCrimes { get; set; }

    [XmlElement("DangerousCriminalHistory")]
    public RIPersonSearchHeaderDetails DangerousCriminalHistory { get; set; }

    [XmlElement("HealthcareFraud")]
    public RIPersonSearchHeaderDetails HealthcareFraud { get; set; }

    [XmlElement("GovernmentProcurementFraud")]
    public RIPersonSearchHeaderDetails GovernmentProcurementFraud { get; set; }

    [XmlElement("TaxFraud")]
    public RIPersonSearchHeaderDetails TaxFraud { get; set; }

    [XmlElement("LitigiousIndividual")]
    public RIPersonSearchHeaderDetails LitigiousIndividual { get; set; }

    [XmlElement("InsuranceFraud")]
    public RIPersonSearchHeaderDetails InsuranceFraud { get; set; }

    [XmlElement("MortgageFraud")]
    public RIPersonSearchHeaderDetails MortgageFraud { get; set; }

    [XmlElement("PropertyCrimes")]
    public RIPersonSearchHeaderDetails PropertyCrimes { get; set; }

    [XmlElement("CriminalHistory")]
    public RIPersonSearchHeaderDetails CriminalHistory { get; set; }

    [XmlElement("Custom")]
    public RIPersonSearchHeaderDetails Custom { get; set; }

    [XmlElement("News")]
    public RIPersonSearchHeaderDetails News { get; set; }

    [XmlElement("WebAnalytics")]
    public RIPersonSearchHeaderDetails WebAnalytics { get; set; }

    [XmlElement("RealTimeIncarcerationRecords")]
    public RIPersonSearchHeaderDetails RealTimeIncarcerationRecords { get; set; }

}
}