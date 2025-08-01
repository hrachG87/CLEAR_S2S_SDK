using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WebAndSocialMediaRecordDetails")]
public class WebAndSocialMediaRecordDetails
{
    [XmlElement("RecordId")]
    public string RecordId { get; set; }

    [XmlElement("WebAndSocialMediaRecord")]
    public WebAndSocialMediaRecord WebAndSocialMediaRecord { get; set; }

    [XmlElement("WebAndSocialMediaDetails")]
    public WebAndSocialMediaDetails WebAndSocialMediaDetails { get; set; }

    [XmlElement("WebResult")]
    public WebResult WebResult { get; set; }

}
}