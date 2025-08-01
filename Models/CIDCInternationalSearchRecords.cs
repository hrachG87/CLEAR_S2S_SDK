using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CIDCInternationalSearchRecords")]
public class CIDCInternationalSearchRecords
{
    [XmlElement("SearchRecord")]
    public List<CIDCInternationalSearchRecord> SearchRecord { get; set; }

}
}