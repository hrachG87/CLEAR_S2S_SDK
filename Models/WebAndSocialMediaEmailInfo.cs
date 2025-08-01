using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("WebAndSocialMediaEmailInfo")]
public class WebAndSocialMediaEmailInfo
{
    [XmlElement("EmailAddress")]
    public string EmailAddress { get; set; }

    [XmlElement("ValidSinceDate")]
    public string ValidSinceDate { get; set; }

}