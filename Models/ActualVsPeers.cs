using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ActualVsPeers")]
public class ActualVsPeers
{
    [XmlElement("CompareDataTable")]
    public List<CompareDataTable> CompareDataTable { get; set; }

}
}