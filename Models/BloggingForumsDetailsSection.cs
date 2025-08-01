using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BloggingForumsDetailsSection")]
public class BloggingForumsDetailsSection
{
    [XmlElement("BloggingForumsDetailsRecord")]
    public List<WebAndSocialMediaRecord> BloggingForumsDetailsRecord { get; set; }

}
}