using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonBirthDate")]
public class PersonBirthDate
{
    [XmlElement("PersonBirthDate")]
    public List<string> PersonBirthDate { get; set; }

    [XmlElement("SourceInfo")]
    public List<SearchSources> SourceInfo { get; set; }

}
}