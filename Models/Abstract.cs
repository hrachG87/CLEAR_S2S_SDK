using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Abstract")]
public class Abstract
{
    [XmlElement("SectionTitle")]
    public string SectionTitle { get; set; }

    [XmlElement("SectionText")]
    public string SectionText { get; set; }

}
}