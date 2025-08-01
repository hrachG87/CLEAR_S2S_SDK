using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AKANameInfo")]
public class AKANameInfo
{
    [XmlElement("NameFirstReported")]
    public string NameFirstReported { get; set; }

    [XmlElement("AKAName")]
    public PersonName AKAName { get; set; }

}
}