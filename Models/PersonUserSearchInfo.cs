using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonUserSearchInfo")]
public class PersonUserSearchInfo
{
    [XmlElement("Name")]
    public PersonName Name { get; set; }

    [XmlElement("PersonProfile")]
    public PersonProfile PersonProfile { get; set; }

    [XmlElement("SSN")]
    public SSNInfo SSN { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

    [XmlElement("DriverLicense")]
    public DriverLicenseInfo DriverLicense { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("CorporationID")]
    public string CorporationID { get; set; }

    [XmlElement("IdNumber")]
    public string IdNumber { get; set; }

    [XmlElement("FilingNumber")]
    public string FilingNumber { get; set; }

    [XmlElement("FilingDate")]
    public string FilingDate { get; set; }

    [XmlElement("DUNS")]
    public string DUNS { get; set; }

    [XmlElement("FederalEmpID")]
    public string FederalEmpID { get; set; }

    [XmlElement("FileTypeCN")]
    public string FileTypeCN { get; set; }

    [XmlElement("FileTypeCN3")]
    public string FileTypeCN3 { get; set; }

    [XmlElement("FileTypeCN5")]
    public string FileTypeCN5 { get; set; }

    [XmlElement("CIK")]
    public string CIK { get; set; }

    [XmlElement("TickerSymbol")]
    public string TickerSymbol { get; set; }

    [XmlElement("Profession")]
    public string Profession { get; set; }

    [XmlElement("ProfessionalLicenseNumber")]
    public string ProfessionalLicenseNumber { get; set; }

    [XmlElement("TitleNumber")]
    public string TitleNumber { get; set; }

    [XmlElement("Year")]
    public string Year { get; set; }

    [XmlElement("Make")]
    public string Make { get; set; }

    [XmlElement("Model")]
    public string Model { get; set; }

    [XmlElement("LicensePlate")]
    public string LicensePlate { get; set; }

    [XmlElement("ParcelNumber")]
    public string ParcelNumber { get; set; }

    [XmlElement("CriminalID")]
    public string CriminalID { get; set; }

    [XmlElement("VesselName")]
    public string VesselName { get; set; }

    [XmlElement("VesselID")]
    public string VesselID { get; set; }

    [XmlElement("HullID")]
    public string HullID { get; set; }

    [XmlElement("EntityId")]
    public string EntityId { get; set; }

    [XmlElement("RiskInformDefinitionName")]
    public string RiskInformDefinitionName { get; set; }

    [XmlElement("RiskInformDefinitionVersion")]
    public string RiskInformDefinitionVersion { get; set; }

    [XmlElement("NPINumber")]
    public string NPINumber { get; set; }

    [XmlElement("VINNumber")]
    public string VINNumber { get; set; }

}