using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("UserNames")]
public class UserNames
{
    [XmlElement("UserName")]
    public List<string> UserName { get; set; }

}
}