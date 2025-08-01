using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Header")]
public class Header
{
    [XmlElement("AllFlags")]
    public RIBusinessSearchHeaderDetails AllFlags { get; set; }

    [XmlElement("SingleRiskIndicators")]
    public RIBusinessSearchHeaderDetails SingleRiskIndicators { get; set; }

    [XmlElement("AddressFlags")]
    public RIBusinessSearchHeaderDetails AddressFlags { get; set; }

    [XmlElement("CompanyDetailsStructure")]
    public RIBusinessSearchHeaderDetails CompanyDetailsStructure { get; set; }

    [XmlElement("PrincipalsExecutivesTiedToBusiness")]
    public RIBusinessSearchHeaderDetails PrincipalsExecutivesTiedToBusiness { get; set; }

    [XmlElement("BusinessRisk")]
    public RIBusinessSearchHeaderDetails BusinessRisk { get; set; }

    [XmlElement("HealthcareRisk")]
    public RIBusinessSearchHeaderDetails HealthcareRisk { get; set; }

    [XmlElement("PartyToRiskBasedLawsuits")]
    public RIBusinessSearchHeaderDetails PartyToRiskBasedLawsuits { get; set; }

    [XmlElement("Custom")]
    public RIBusinessSearchHeaderDetails Custom { get; set; }

    [XmlElement("News")]
    public RIBusinessSearchHeaderDetails News { get; set; }

    [XmlElement("WebAnalytics")]
    public RIBusinessSearchHeaderDetails WebAnalytics { get; set; }

}