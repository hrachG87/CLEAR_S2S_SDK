using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DunBradstreetPCIRecord")]
public class DunBradstreetPCIRecord
{
    [XmlElement("GeneralInformation")]
    public GeneralInformation GeneralInformation { get; set; }

    [XmlElement("KeyFacts")]
    public KeyFacts KeyFacts { get; set; }

    [XmlElement("CompanyOfficerHistory")]
    public CompanyOfficerHistory CompanyOfficerHistory { get; set; }

    [XmlElement("FinancialOverview")]
    public FinancialOverview FinancialOverview { get; set; }

    [XmlElement("ThreeYearComparison")]
    public TableLayout ThreeYearComparison { get; set; }

    [XmlElement("KeyBusinessRatios")]
    public KeyBusinessRatios KeyBusinessRatios { get; set; }

    [XmlElement("IndustryComparison")]
    public BusinessNoteInfo IndustryComparison { get; set; }

    [XmlElement("ActualVsPeers")]
    public ActualVsPeers ActualVsPeers { get; set; }

    [XmlElement("ReturnOnSalesIndustryComparison")]
    public TableLayout ReturnOnSalesIndustryComparison { get; set; }

    [XmlElement("FamilyTreeOverview")]
    public FamilyTreeOverview FamilyTreeOverview { get; set; }

    [XmlElement("PublicRecordsOverview")]
    public PublicRecordsOverview PublicRecordsOverview { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }
}
