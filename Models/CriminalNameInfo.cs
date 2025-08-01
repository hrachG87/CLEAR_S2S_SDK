using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalNameInfo")]
public class CriminalNameInfo
{
    [XmlElement("EntityType")]
    public string EntityType { get; set; }

    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("DoingBusinessAs")]
    public List<string> DoingBusinessAs { get; set; }

    [XmlElement("FormerlyKnownAs")]
    public List<string> FormerlyKnownAs { get; set; }

    [XmlElement("PersonProfile")]
    public PersonProfile PersonProfile { get; set; }

    [XmlElement("AlternativeSpelling")]
    public string AlternativeSpelling { get; set; }

    [XmlElement("Address")]
    public List<CommonDataAddress> Address { get; set; }

    [XmlElement("AdditionalCountry")]
    public List<string> AdditionalCountry { get; set; }

    [XmlElement("SSNInfo")]
    public SSNInfo SSNInfo { get; set; }

    [XmlElement("AKAName")]
    public List<string> AKAName { get; set; }

}
}