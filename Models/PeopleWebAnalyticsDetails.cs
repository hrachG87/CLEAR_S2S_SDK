using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PeopleWebAnalyticsDetails")]
public class PeopleWebAnalyticsDetails
{
    [XmlElement("PersonInfo")]
    public WebAnalyticsImageInfo PersonInfo { get; set; }

    [XmlElement("CareerInfo")]
    public CareerInfo CareerInfo { get; set; }

    [XmlElement("EducationInfo")]
    public WebAnalyticsEducationInfo EducationInfo { get; set; }

    [XmlElement("UserNames")]
    public UserNames UserNames { get; set; }

    [XmlElement("PhoneNumbers")]
    public PhoneNumbers PhoneNumbers { get; set; }

    [XmlElement("AdditionalNames")]
    public AdditionalNames AdditionalNames { get; set; }

    [XmlElement("Places")]
    public Places Places { get; set; }

    [XmlElement("AssociatedWith")]
    public AssociatedWith AssociatedWith { get; set; }

    [XmlElement("Sources")]
    public List<WebAnalyticsSources> Sources { get; set; }

    [XmlElement("PossiblyRelatedSources")]
    public List<PossiblyRelatedSources> PossiblyRelatedSources { get; set; }

}