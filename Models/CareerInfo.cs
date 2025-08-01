using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CareerInfo")]
public class CareerInfo
{
    [XmlElement("Job")]
    public List<string> Job { get; set; }

}
}