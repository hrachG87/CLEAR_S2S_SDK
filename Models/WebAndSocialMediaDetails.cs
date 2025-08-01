using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WebAndSocialMediaDetails")]
public class WebAndSocialMediaDetails
{
    [XmlElement("ImageInfo")]
    public List<ImageInfo> ImageInfo { get; set; }

    [XmlElement("Age")]
    public string Age { get; set; }

    [XmlElement("Gender")]
    public string Gender { get; set; }

    [XmlElement("Volunteering")]
    public List<string> Volunteering { get; set; }

    [XmlElement("Alias")]
    public List<WebAndSocialMediaNameInfo> Alias { get; set; }

    [XmlElement("Language")]
    public List<string> Language { get; set; }

    [XmlElement("PhoneInfo")]
    public List<WebAndSocialMediaPhoneInfo> PhoneInfo { get; set; }

    [XmlElement("EmailInfo")]
    public List<WebAndSocialMediaEmailInfo> EmailInfo { get; set; }

    [XmlElement("Username")]
    public List<UsernameInfo> Username { get; set; }

    [XmlElement("RelatedWebsiteInfo")]
    public List<RelatedWebsiteInfo> RelatedWebsiteInfo { get; set; }

    [XmlElement("EducationInfo")]
    public List<EducationInfo> EducationInfo { get; set; }

    [XmlElement("AddressInfo")]
    public List<AddressInfo> AddressInfo { get; set; }

    [XmlElement("JobInfo")]
    public List<JobInfo> JobInfo { get; set; }

    [XmlElement("InterestInfo")]
    public List<InterestInfo> InterestInfo { get; set; }

    [XmlElement("AssociateInfo")]
    public List<WebAndSocialMediaAssociateInfo> AssociateInfo { get; set; }

    [XmlElement("SocialMediaInfo")]
    public List<SocialMediaInfo> SocialMediaInfo { get; set; }
}
