using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PictureVideoSharingDetailsSection")]
public class PictureVideoSharingDetailsSection
{
    [XmlElement("PictureVideoSharingDetailsRecord")]
    public List<WebAndSocialMediaRecord> PictureVideoSharingDetailsRecord { get; set; }

}
}