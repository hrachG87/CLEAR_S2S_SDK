using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyNames")]
public class CompanyNames
{
    [XmlElement("CompanyName")]
    public List<string> CompanyName { get; set; }

}
}