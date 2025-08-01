using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("KeyFacts")]
public class KeyFacts
{
    [XmlElement("Sales")]
    public string Sales { get; set; }

    [XmlElement("SalesEffectiveDate")]
    public string SalesEffectiveDate { get; set; }

    [XmlElement("SalesType")]
    public string SalesType { get; set; }

    [XmlElement("SalesComparison")]
    public string SalesComparison { get; set; }

    [XmlElement("SalesPeriodDescription")]
    public string SalesPeriodDescription { get; set; }

    [XmlElement("NetWorth")]
    public string NetWorth { get; set; }

    [XmlElement("NetWorthEffectiveDate")]
    public string NetWorthEffectiveDate { get; set; }

    [XmlElement("NetWorthType")]
    public string NetWorthType { get; set; }

    [XmlElement("NetWorthComparison")]
    public string NetWorthComparison { get; set; }

    [XmlElement("NetWorthPeriodDescription")]
    public string NetWorthPeriodDescription { get; set; }

    [XmlElement("FinancialStatement")]
    public string FinancialStatement { get; set; }

    [XmlElement("History")]
    public string History { get; set; }

    [XmlElement("RegionOfBusiness")]
    public string RegionOfBusiness { get; set; }

    [XmlElement("YearStarted")]
    public string YearStarted { get; set; }

    [XmlElement("YearPresentManagementControl")]
    public string YearPresentManagementControl { get; set; }

    [XmlElement("TotalEmployees")]
    public string TotalEmployees { get; set; }

    [XmlElement("EmployeesAtLocation")]
    public string EmployeesAtLocation { get; set; }

    [XmlElement("BranchSingleLocation")]
    public string BranchSingleLocation { get; set; }

    [XmlElement("Officers")]
    public List<BusinessOfficerInfo> Officers { get; set; }

    [XmlElement("Directors")]
    public string Directors { get; set; }

    [XmlElement("OperationDescription")]
    public OperationsDescription OperationDescription { get; set; }

    [XmlElement("SICAndNAICS")]
    public List<SICInfo> SICAndNAICS { get; set; }

}
}