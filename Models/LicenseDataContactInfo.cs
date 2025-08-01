using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("LicenseDataContactInfo")]
public class LicenseDataContactInfo
{
    [XmlElement("PhoneInfo")]
    public PhoneInfo PhoneInfo { get; set; }

    [XmlElement("ContactEmailID")]
    public string ContactEmailID { get; set; }

    [XmlElement("ContactWebsiteURL")]
    public string ContactWebsiteURL { get; set; }

}