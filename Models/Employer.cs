using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Employer")]
public class Employer
{
    [XmlElement("BusinessLicense")]
    public LicenseDataLicenseInfo BusinessLicense { get; set; }

    [XmlElement("TypeofBusiness")]
    public string TypeofBusiness { get; set; }

    [XmlElement("DoingBusinessAsName")]
    public string DoingBusinessAsName { get; set; }

    [XmlElement("BusinessLocation")]
    public string BusinessLocation { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }
}
