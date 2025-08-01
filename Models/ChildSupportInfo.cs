using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ChildSupportInfo")]
public class ChildSupportInfo
{
    [XmlElement("ChildSupportAmount")]
    public string ChildSupportAmount { get; set; }

    [XmlElement("ChildrenUnder18")]
    public string ChildrenUnder18 { get; set; }

    [XmlElement("CustodyAwardedTo")]
    public string CustodyAwardedTo { get; set; }

}
}