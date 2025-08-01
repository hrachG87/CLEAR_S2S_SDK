using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CourtCriteria")]
public class CourtCriteria
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("PersonName")]
    public CourtNameCriteria PersonName { get; set; }

    [XmlElement("Address")]
    public CourtAddressCriteria Address { get; set; }

    [XmlElement("PersonBirthDate")]
    public string PersonBirthDate { get; set; }

    [XmlElement("SSN")]
    public string SSN { get; set; }

    [XmlElement("CriminalID")]
    public string CriminalID { get; set; }

    [XmlElement("FederalEmpID")]
    public string FederalEmpID { get; set; }

    [XmlElement("FilingNumber")]
    public string FilingNumber { get; set; }

    [XmlElement("FilingDate")]
    public string FilingDate { get; set; }

    [XmlElement("DocGuid")]
    public string DocGuid { get; set; }

    [XmlElement("DriverLicenseNumber")]
    public string DriverLicenseNumber { get; set; }

}