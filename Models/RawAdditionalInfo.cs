using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RawAdditionalInfo")]
public class RawAdditionalInfo
{
    [XmlElement("Key")]
    public string Key { get; set; }

    [XmlElement("Value")]
    public string Value { get; set; }

    [XmlElement("ValueOriginalLanguage")]
    public string ValueOriginalLanguage { get; set; }

    [XmlElement("Known")]
    public bool Known { get; set; }

}
}