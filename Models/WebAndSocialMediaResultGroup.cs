using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WebAndSocialMediaResultGroup")]
public class WebAndSocialMediaResultGroup
{
    [XmlElement("RecordDetails")]
    public WebAndSocialMediaRecordDetails RecordDetails { get; set; }
}
