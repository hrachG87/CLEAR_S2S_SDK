using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WebAndSocialMediaSearchRequest")]
public class WebAndSocialMediaSearchRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public WebAndSocialMediaCriteria Criteria { get; set; }
}
