using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CountInfo")]
public class CountInfo
{
    [XmlElement("Count")]
    public string Count { get; set; }

    [XmlElement("Disposition")]
    public string Disposition { get; set; }

}
}