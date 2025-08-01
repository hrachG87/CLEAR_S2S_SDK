using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BodyMarkInfo")]
public class BodyMarkInfo
{
    [XmlElement("BodyMarkings")]
    public List<PersonProfile> BodyMarkings { get; set; }

}
}