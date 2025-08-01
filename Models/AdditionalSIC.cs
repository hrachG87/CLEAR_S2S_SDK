using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdditionalSIC")]
public class AdditionalSIC
{
    [XmlElement("SICInfo2")]
    public List<SICInfo> SICInfo2 { get; set; }

    [XmlElement("SICInfo3")]
    public List<SICInfo> SICInfo3 { get; set; }

    [XmlElement("SICInfo4")]
    public List<SICInfo> SICInfo4 { get; set; }

    [XmlElement("SICInfo5")]
    public List<SICInfo> SICInfo5 { get; set; }

    [XmlElement("SICInfo6")]
    public List<SICInfo> SICInfo6 { get; set; }

}
}