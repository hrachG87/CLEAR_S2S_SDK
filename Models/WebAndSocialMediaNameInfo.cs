using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WebAndSocialMediaNameInfo")]
public class WebAndSocialMediaNameInfo
{
    [XmlElement("FirstName")]
    public string FirstName { get; set; }

    [XmlElement("MiddleName")]
    public string MiddleName { get; set; }

    [XmlElement("LastName")]
    public string LastName { get; set; }

    [XmlElement("FullName")]
    public string FullName { get; set; }
}
