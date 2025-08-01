using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("WebAndSocialMediaCriteria")]
public class WebAndSocialMediaCriteria
{
    [XmlElement("WebAndSocialSearchMediaCriteria")]
    public WebAndSocialMediaSearchCriteria WebAndSocialSearchMediaCriteria { get; set; }

}