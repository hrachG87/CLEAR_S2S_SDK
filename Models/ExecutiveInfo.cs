using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ExecutiveInfo")]
public class ExecutiveInfo
{
    [XmlElement("ExecutiveName")]
    public string ExecutiveName { get; set; }

    [XmlElement("ExecutiveTitle")]
    public string ExecutiveTitle { get; set; }

    [XmlElement("Title")]
    public string Title { get; set; }

    [XmlElement("Contact")]
    public string Contact { get; set; }

    [XmlElement("NameTitle")]
    public List<string> NameTitle { get; set; }

    [XmlElement("HolderName")]
    public List<string> HolderName { get; set; }

    [XmlElement("Age")]
    public string Age { get; set; }

    [XmlElement("StartDate")]
    public string StartDate { get; set; }

    [XmlElement("Since")]
    public string Since { get; set; }

    [XmlElement("CEOName")]
    public string CEOName { get; set; }

}
}