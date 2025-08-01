using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Collaterals")]
public class Collaterals
{
    [XmlElement("Collateral")]
    public List<string> Collateral { get; set; }

}
}