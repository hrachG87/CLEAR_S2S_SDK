using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("NationalID")]
public class NationalID
{
    [XmlElement("value")]
    public string value { get; set; }

    [XmlElement("idType")]
    public string idType { get; set; }

}
}