using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("UsernamesSection")]
public class UsernamesSection
{
    [XmlElement("UsernamesRecord")]
    public List<UsernameInfo> UsernamesRecord { get; set; }

}
}