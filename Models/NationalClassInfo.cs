using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("NationalClassInfo")]
public class NationalClassInfo
{
    [XmlElement("NationalClass")]
    public string NationalClass { get; set; }

    [XmlElement("NationalSubClass")]
    public string NationalSubClass { get; set; }

}
}