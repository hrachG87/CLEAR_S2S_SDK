using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("OwnerRoles")]
public class OwnerRoles
{
    [XmlElement("Role")]
    public List<string> Role { get; set; }

    [XmlElement("RoleClass")]
    public string RoleClass { get; set; }

}
}