using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PoliticalDonorRecord")]
public class PoliticalDonorRecord
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("Employer")]
    public string Employer { get; set; }

    [XmlElement("FirstAmount")]
    public string FirstAmount { get; set; }

    [XmlElement("FirstAmountContributionDate")]
    public string FirstAmountContributionDate { get; set; }

    [XmlElement("LastAmount")]
    public string LastAmount { get; set; }

    [XmlElement("LastAmountContributionDate")]
    public string LastAmountContributionDate { get; set; }

    [XmlElement("LastParty")]
    public string LastParty { get; set; }

    [XmlElement("TotalAmount")]
    public string TotalAmount { get; set; }

    [XmlElement("TotalDemocratAmount")]
    public string TotalDemocratAmount { get; set; }

    [XmlElement("TotalRepublicanAmount")]
    public string TotalRepublicanAmount { get; set; }

    [XmlElement("EmployeeOccupation")]
    public string EmployeeOccupation { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("PACCommitteeName")]
    public string PACCommitteeName { get; set; }
}
