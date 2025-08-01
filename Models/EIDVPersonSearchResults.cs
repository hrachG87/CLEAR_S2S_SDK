using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EIDVPersonSearchResults")]
public class EIDVPersonSearchResults
{
    [XmlElement("eidvpersonSearchResult")]
    public EIDVPersonSearchResult eidvpersonSearchResult { get; set; }

}
}