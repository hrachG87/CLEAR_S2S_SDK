using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Content")]
public class Content
{
    [XmlElement("value")]
    public string value { get; set; }

    [XmlElement("name")]
    public string name { get; set; }

}
}