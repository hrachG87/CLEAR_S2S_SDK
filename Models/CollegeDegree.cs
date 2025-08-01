using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CollegeDegree")]
public class CollegeDegree
{
    [XmlElement("BasicDegree")]
    public string BasicDegree { get; set; }

    [XmlElement("HighestDegree")]
    public string HighestDegree { get; set; }

    [XmlElement("DegreeEarned")]
    public string DegreeEarned { get; set; }

}
}