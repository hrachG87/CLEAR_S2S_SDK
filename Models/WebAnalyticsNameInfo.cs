using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("WebAnalyticsNameInfo")]
public class WebAnalyticsNameInfo
{
    [XmlElement("FirstName")]
    public string FirstName { get; set; }

    [XmlElement("MiddleName")]
    public string MiddleName { get; set; }

    [XmlElement("LastName")]
    public string LastName { get; set; }

}