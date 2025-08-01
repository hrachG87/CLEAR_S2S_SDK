using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("StatusInfo")]
public class StatusInfo
{
    [XmlElement("Status")]
    public string Status { get; set; }

    [XmlElement("StatusDate")]
    public string StatusDate { get; set; }

}
}