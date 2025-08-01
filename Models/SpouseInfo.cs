using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SpouseInfo")]
public class SpouseInfo
{
    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("SSN")]
    public string SSN { get; set; }

}
}