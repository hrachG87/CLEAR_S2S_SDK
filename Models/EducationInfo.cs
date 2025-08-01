using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EducationInfo")]
public class EducationInfo
{
    [XmlElement("School")]
    public string School { get; set; }

    [XmlElement("EducationLevel")]
    public string EducationLevel { get; set; }

    [XmlElement("StartDate")]
    public string StartDate { get; set; }

    [XmlElement("EndDate")]
    public string EndDate { get; set; }

}
}