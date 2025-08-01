using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("MRZ")]
public class MRZ
{
    [XmlElement("UpperLine")]
    public string UpperLine { get; set; }

    [XmlElement("LowerLine")]
    public string LowerLine { get; set; }

}
}