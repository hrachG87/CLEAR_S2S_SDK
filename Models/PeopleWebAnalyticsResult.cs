using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PeopleWebAnalyticsResult")]
public class PeopleWebAnalyticsResult
{
    [XmlElement("Image")]
    public string Image { get; set; }

    [XmlElement("Name")]
    public WebAnalyticsPersonName Name { get; set; }

    [XmlElement("PersonPlaces")]
    public PersonPlaces PersonPlaces { get; set; }

    [XmlElement("PersonJobs")]
    public PersonJobs PersonJobs { get; set; }

    [XmlElement("Associations")]
    public Associations Associations { get; set; }

}
}