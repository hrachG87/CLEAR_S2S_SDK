using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("JobInfo")]
public class JobInfo
{
    [XmlElement("Organization")]
    public string Organization { get; set; }

    [XmlElement("Industry")]
    public string Industry { get; set; }

    [XmlElement("Title")]
    public string Title { get; set; }

    [XmlElement("Current")]
    public string Current { get; set; }

    [XmlElement("StartDate")]
    public string StartDate { get; set; }

    [XmlElement("EndDate")]
    public string EndDate { get; set; }

    [XmlElement("ValidSinceDate")]
    public string ValidSinceDate { get; set; }

}
}