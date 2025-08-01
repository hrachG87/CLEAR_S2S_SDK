using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("NoMatchSections")]
public class NoMatchSections
{
    [XmlElement("noMatchSection")]
    public List<string> noMatchSection { get; set; }

}
}