using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIPersonSearchSections")]
public class RIPersonSearchSections
{
    [XmlElement("Section")]
    public List<RIPersonSearchSection> Section { get; set; }

}
}