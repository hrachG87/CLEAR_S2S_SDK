using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("UtilityRecord")]
public class UtilityRecord
{
    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("BillingAddress")]
    public CommonDataAddress BillingAddress { get; set; }

    [XmlElement("DriverLicenseInfo")]
    public DriverLicenseInfo DriverLicenseInfo { get; set; }

    [XmlElement("PhoneInfo")]
    public PhoneInfo PhoneInfo { get; set; }

    [XmlElement("ServiceConnectDate")]
    public string ServiceConnectDate { get; set; }

    [XmlElement("UtilityAddress")]
    public CommonDataAddress UtilityAddress { get; set; }

    [XmlElement("UtilityReportedDate")]
    public string UtilityReportedDate { get; set; }

    [XmlElement("UtilityService")]
    public List<string> UtilityService { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("SSNInfo")]
    public SSNInfo SSNInfo { get; set; }

}