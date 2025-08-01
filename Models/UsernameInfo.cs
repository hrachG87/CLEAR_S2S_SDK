using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("UsernameInfo")]
public class UsernameInfo
{
    [XmlElement("Username")]
    public string Username { get; set; }

    [XmlElement("URL")]
    public string URL { get; set; }

}
}