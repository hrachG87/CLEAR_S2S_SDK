using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ListsResult")]
public class ListsResult
{
    [XmlElement("ListNames")]
    public ListNames ListNames { get; set; }

}
}