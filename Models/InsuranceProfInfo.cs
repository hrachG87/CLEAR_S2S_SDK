using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("InsuranceProfInfo")]
public class InsuranceProfInfo
{
    [XmlElement("AssetAmount")]
    public string AssetAmount { get; set; }

    [XmlElement("AttorneyAddress")]
    public CommonDataAddress AttorneyAddress { get; set; }

    [XmlElement("AttorneyInFact")]
    public string AttorneyInFact { get; set; }

    [XmlElement("AttorneySvcOfProcess")]
    public string AttorneySvcOfProcess { get; set; }

    [XmlElement("CapitalAmount")]
    public string CapitalAmount { get; set; }

    [XmlElement("CompanyContact")]
    public string CompanyContact { get; set; }

    [XmlElement("CompanyPresident")]
    public string CompanyPresident { get; set; }

    [XmlElement("CreditExpireDate")]
    public string CreditExpireDate { get; set; }

    [XmlElement("CreditIssueDate")]
    public string CreditIssueDate { get; set; }

    [XmlElement("CreditStartDate")]
    public string CreditStartDate { get; set; }

    [XmlElement("DomicileCityState")]
    public string DomicileCityState { get; set; }

    [XmlElement("IncorpDate")]
    public string IncorpDate { get; set; }

    [XmlElement("LifeInForce")]
    public string LifeInForce { get; set; }

    [XmlElement("NetSurplus")]
    public string NetSurplus { get; set; }

    [XmlElement("Secretary")]
    public string Secretary { get; set; }

    [XmlElement("Treasurer")]
    public string Treasurer { get; set; }

    [XmlElement("NAICCompany")]
    public string NAICCompany { get; set; }

    [XmlElement("NAICGroup")]
    public string NAICGroup { get; set; }
}
