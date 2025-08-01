using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonReportImageInfo")]
public class PersonReportImageInfo
{
    [XmlElement("BinaryImage")]
    public string BinaryImage { get; set; }

    [XmlElement("ContentType")]
    public string ContentType { get; set; }

}
}