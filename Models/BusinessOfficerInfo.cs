using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessOfficerInfo")]
public class BusinessOfficerInfo
{
    [XmlElement("OfficerName")]
    public string OfficerName { get; set; }

    [XmlElement("OfficerTitle")]
    public string OfficerTitle { get; set; }

}
}