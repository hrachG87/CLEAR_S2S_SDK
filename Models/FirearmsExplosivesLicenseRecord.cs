using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("FirearmsExplosivesLicenseRecord")]
public class FirearmsExplosivesLicenseRecord
{
    [XmlElement("BusinessInfo")]
    public LicenseDataBusinessInfo BusinessInfo { get; set; }

    [XmlElement("CountyCodeOrName")]
    public string CountyCodeOrName { get; set; }

    [XmlElement("LicenseExpirationMonth")]
    public string LicenseExpirationMonth { get; set; }

    [XmlElement("LicenseExpirationYear")]
    public string LicenseExpirationYear { get; set; }

    [XmlElement("MailingAddress")]
    public CommonDataAddress MailingAddress { get; set; }

    [XmlElement("PersonLicense")]
    public string PersonLicense { get; set; }

    [XmlElement("Region")]
    public string Region { get; set; }

    [XmlElement("TypeOfLicense")]
    public string TypeOfLicense { get; set; }

    [XmlElement("DocumentFiledDate")]
    public string DocumentFiledDate { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("IRSDistrict")]
    public string IRSDistrict { get; set; }

}