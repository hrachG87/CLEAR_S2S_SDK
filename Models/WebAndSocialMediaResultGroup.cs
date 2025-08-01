using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WebAndSocialMediaResultGroup")]
public class WebAndSocialMediaResultGroup
{
    [XmlElement("RecordDetails")]
    public WebAndSocialMediaRecordDetails RecordDetails { get; set; }

}
}