using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("OperationsDescription")]
public class OperationsDescription
{
    [XmlElement("Description")]
    public List<string> Description { get; set; }

}
}