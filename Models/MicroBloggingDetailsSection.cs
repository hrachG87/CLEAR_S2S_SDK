using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("MicroBloggingDetailsSection")]
public class MicroBloggingDetailsSection
{
    [XmlElement("MicroBloggingDetailsRecord")]
    public List<WebAndSocialMediaRecord> MicroBloggingDetailsRecord { get; set; }

}
}