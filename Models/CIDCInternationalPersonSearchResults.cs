using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CIDCInternationalPersonSearchResults")]
public class CIDCInternationalPersonSearchResults
{
    [XmlElement("CIDCInternationalPersonSearchResult")]
    public CIDCInternationalPersonSearchResult CIDCInternationalPersonSearchResult { get; set; }

}
}