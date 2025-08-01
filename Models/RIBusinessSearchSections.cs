using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIBusinessSearchSections")]
public class RIBusinessSearchSections
{
    [XmlElement("Section")]
    public List<RIBusinessSearchSection> Section { get; set; }

}
}