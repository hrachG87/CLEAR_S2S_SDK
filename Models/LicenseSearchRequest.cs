using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("LicenseSearchRequest")]
public class LicenseSearchRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public LicenseUserCriteria Criteria { get; set; }

    [XmlElement("Datasources")]
    public LicenseDatasources Datasources { get; set; }

    [XmlElement("DriverLicensesDatasets")]
    public DriverLicensesDatasets DriverLicensesDatasets { get; set; }

    [XmlElement("LicensesDatasets")]
    public LicensesDatasets LicensesDatasets { get; set; }

}