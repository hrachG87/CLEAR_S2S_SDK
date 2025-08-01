using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DocketPartyInfo")]
public class DocketPartyInfo
{
    [XmlElement("DocketPartyName")]
    public string DocketPartyName { get; set; }

    [XmlElement("DocketPartyType")]
    public string DocketPartyType { get; set; }

}
}