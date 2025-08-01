using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyPhoneInfo")]
public class CompanyPhoneInfo
{
    [XmlElement("CompanyName")]
    public string CompanyName { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }
}
