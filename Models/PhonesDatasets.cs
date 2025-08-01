using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PhonesDatasets")]
public class PhonesDatasets
{
    [XmlElement("BusinessPhones")]
    public string BusinessPhones { get; set; }

    [XmlElement("CanadianBusinessPhones")]
    public string CanadianBusinessPhones { get; set; }

    [XmlElement("CanadianPhones")]
    public string CanadianPhones { get; set; }

    [XmlElement("Experian")]
    public string Experian { get; set; }

    [XmlElement("DunBradstreet")]
    public string DunBradstreet { get; set; }

    [XmlElement("HouseholdListings")]
    public string HouseholdListings { get; set; }

    [XmlElement("PhoneRecords")]
    public string PhoneRecords { get; set; }

    [XmlElement("TransUnion")]
    public string TransUnion { get; set; }

    [XmlElement("UtilityListing")]
    public string UtilityListing { get; set; }

    [XmlElement("Worldbase")]
    public string Worldbase { get; set; }

    [XmlElement("MotorVehicleServiceAndWarrantyRecords")]
    public string MotorVehicleServiceAndWarrantyRecords { get; set; }

    [XmlElement("MarijuanaRelatedBusinesses")]
    public string MarijuanaRelatedBusinesses { get; set; }

    [XmlElement("BankAccountHeader")]
    public string BankAccountHeader { get; set; }

    [XmlElement("BusinessContactRecords")]
    public string BusinessContactRecords { get; set; }
}
