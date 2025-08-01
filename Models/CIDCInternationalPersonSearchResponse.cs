using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CIDCInternationalPersonSearchResponse")]
public class CIDCInternationalPersonSearchResponse
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("CIDCInternationalPersonSearchResults")]
    public List<CIDCInternationalPersonSearchResults> CIDCInternationalPersonSearchResults { get; set; }

}
}