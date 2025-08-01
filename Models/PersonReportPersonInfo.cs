using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonReportPersonInfo")]
public class PersonReportPersonInfo
{
    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("PersonProfile")]
    public PersonProfile PersonProfile { get; set; }

    [XmlElement("PersonSSN")]
    public SSNInfo PersonSSN { get; set; }

    [XmlElement("PersonSourceInfo")]
    public List<SearchSources> PersonSourceInfo { get; set; }

}
}