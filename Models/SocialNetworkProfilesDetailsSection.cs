using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SocialNetworkProfilesDetailsSection")]
public class SocialNetworkProfilesDetailsSection
{
    [XmlElement("SocialNetworkProfilesDetailsRecord")]
    public List<WebAndSocialMediaRecord> SocialNetworkProfilesDetailsRecord { get; set; }

}
}