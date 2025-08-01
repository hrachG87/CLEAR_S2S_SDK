using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EIDVBusinessSearch")]
public class EIDVBusinessSearch
{
    [XmlElement("PermissiblePurpose")]
    public EidvBusinessPermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("EIDVBusinessSearchRequest")]
    public EIDVBusinessSearchRequest EIDVBusinessSearchRequest { get; set; }

}
}