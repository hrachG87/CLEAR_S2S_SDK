using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PeopleDatasets")]
public class PeopleDatasets
{
    [XmlElement("AddressCompilation")]
    public string AddressCompilation { get; set; }

    [XmlElement("CanadianPhones")]
    public string CanadianPhones { get; set; }

    [XmlElement("DriverLicenses")]
    public string DriverLicenses { get; set; }

    [XmlElement("Experian")]
    public string Experian { get; set; }

    [XmlElement("HistoricCreditBureau")]
    public string HistoricCreditBureau { get; set; }

    [XmlElement("HouseholdListings")]
    public string HouseholdListings { get; set; }

    [XmlElement("NewMovers")]
    public string NewMovers { get; set; }

    [XmlElement("ObituaryRecords")]
    public string ObituaryRecords { get; set; }

    [XmlElement("PhoneRecords")]
    public string PhoneRecords { get; set; }

    [XmlElement("StateDeath")]
    public string StateDeath { get; set; }

    [XmlElement("TransUnion")]
    public string TransUnion { get; set; }

    [XmlElement("UtilityListing")]
    public string UtilityListing { get; set; }

    [XmlElement("EquifaxCreditHeader")]
    public string EquifaxCreditHeader { get; set; }

    [XmlElement("BankAccountHeader")]
    public string BankAccountHeader { get; set; }

    [XmlElement("BusinessContactRecords")]
    public string BusinessContactRecords { get; set; }

    [XmlElement("SSADeath")]
    public string SSADeath { get; set; }

}