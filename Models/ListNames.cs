using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ListNames")]
public class ListNames
{
    [XmlElement("ListName")]
    public List<string> ListName { get; set; }

}
}