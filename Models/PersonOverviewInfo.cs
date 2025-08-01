using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonOverviewInfo")]
public class PersonOverviewInfo
{
    [XmlElement("ImageInfo")]
    public List<ImageInfo> ImageInfo { get; set; }

    [XmlElement("Age")]
    public string Age { get; set; }

    [XmlElement("Gender")]
    public List<AddressInfo> Gender { get; set; }

    [XmlElement("Volunteering")]
    public List<string> Volunteering { get; set; }

    [XmlElement("Alias")]
    public List<WebAndSocialMediaNameInfo> Alias { get; set; }

    [XmlElement("Language")]
    public List<string> Language { get; set; }

    [XmlElement("RelatedWebsiteInfo")]
    public List<RelatedWebsiteInfo> RelatedWebsiteInfo { get; set; }

    [XmlElement("AssociateInfo")]
    public List<WebAndSocialMediaAssociateInfo> AssociateInfo { get; set; }

    [XmlElement("NetWorth")]
    public string NetWorth { get; set; }

    [XmlElement("InterestInfo")]
    public List<SocialMediaInfo> InterestInfo { get; set; }

}
}