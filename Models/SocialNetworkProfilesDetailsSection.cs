using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("SocialNetworkProfilesDetailsSection")]
public class SocialNetworkProfilesDetailsSection
{
    [XmlElement("SocialNetworkProfilesDetailsRecord")]
    public List<WebAndSocialMediaRecord> SocialNetworkProfilesDetailsRecord { get; set; }
}
