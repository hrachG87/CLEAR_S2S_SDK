using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DunBradstreetRecord")]
public class DunBradstreetRecord
{
    [XmlElement("BusinessInfo")]
    public BusinessDataBusinessInfo BusinessInfo { get; set; }

    [XmlElement("EstablishedManufacturingIndicator")]
    public string EstablishedManufacturingIndicator { get; set; }

    [XmlElement("PersonInfo")]
    public List<BusinessPersonInfo> PersonInfo { get; set; }

    [XmlElement("ForeignOwned")]
    public string ForeignOwned { get; set; }

    [XmlElement("HomeOrCottageBusiness")]
    public string HomeOrCottageBusiness { get; set; }

    [XmlElement("IncorporationDate")]
    public string IncorporationDate { get; set; }

    [XmlElement("LatestSales")]
    public string LatestSales { get; set; }

    [XmlElement("ManufacturingLocation")]
    public string ManufacturingLocation { get; set; }

    [XmlElement("MinorityOwned")]
    public string MinorityOwned { get; set; }

    [XmlElement("NumberOfEmployeesHere")]
    public string NumberOfEmployeesHere { get; set; }

    [XmlElement("OccupancyType")]
    public string OccupancyType { get; set; }

    [XmlElement("PublicallyOwned")]
    public string PublicallyOwned { get; set; }

    [XmlElement("RevisionDate")]
    public string RevisionDate { get; set; }

    [XmlElement("AdditionalSIC")]
    public AdditionalSIC AdditionalSIC { get; set; }

    [XmlElement("SecondaryCompanyName")]
    public string SecondaryCompanyName { get; set; }

    [XmlElement("SmallBusiness")]
    public string SmallBusiness { get; set; }

    [XmlElement("SquareFootageOfBuilding")]
    public string SquareFootageOfBuilding { get; set; }

    [XmlElement("StateOfIncorporation")]
    public string StateOfIncorporation { get; set; }

    [XmlElement("YearStarted")]
    public string YearStarted { get; set; }

    [XmlElement("LineOfBusiness")]
    public string LineOfBusiness { get; set; }

    [XmlElement("IndustryGroup")]
    public string IndustryGroup { get; set; }

    [XmlElement("Sales1YrAgo")]
    public string Sales1YrAgo { get; set; }

    [XmlElement("Sales3YrAgo")]
    public string Sales3YrAgo { get; set; }

    [XmlElement("SalesGrowth")]
    public string SalesGrowth { get; set; }

    [XmlElement("SalesTerritory")]
    public string SalesTerritory { get; set; }

    [XmlElement("NumberOfAccounts")]
    public string NumberOfAccounts { get; set; }

    [XmlElement("NetWorth")]
    public string NetWorth { get; set; }

    [XmlElement("EmployeeTotal")]
    public string EmployeeTotal { get; set; }

    [XmlElement("EmpTotal3YrAgo")]
    public string EmpTotal3YrAgo { get; set; }

    [XmlElement("EmpTotal1YrAgo")]
    public string EmpTotal1YrAgo { get; set; }

    [XmlElement("EmploymentGrowth")]
    public string EmploymentGrowth { get; set; }

    [XmlElement("BusinessIsA")]
    public string BusinessIsA { get; set; }

    [XmlElement("EstablishmentIs")]
    public string EstablishmentIs { get; set; }

    [XmlElement("BankName")]
    public string BankName { get; set; }

    [XmlElement("BankDUNSNumber")]
    public string BankDUNSNumber { get; set; }

    [XmlElement("AccountingFirm")]
    public string AccountingFirm { get; set; }

    [XmlElement("ParentCompanyName")]
    public string ParentCompanyName { get; set; }

    [XmlElement("ParentCompanyDUNS")]
    public string ParentCompanyDUNS { get; set; }

    [XmlElement("UltimateCompanyName")]
    public string UltimateCompanyName { get; set; }

    [XmlElement("UltimateCompanyDUNS")]
    public string UltimateCompanyDUNS { get; set; }

    [XmlElement("HeadquartersName")]
    public string HeadquartersName { get; set; }

    [XmlElement("HeadquartersDUNS")]
    public string HeadquartersDUNS { get; set; }

    [XmlElement("OtherDUNS")]
    public string OtherDUNS { get; set; }

    [XmlElement("RecordUpdateDate")]
    public string RecordUpdateDate { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("MSACode")]
    public string MSACode { get; set; }

    [XmlElement("MSAName")]
    public string MSAName { get; set; }

}
}