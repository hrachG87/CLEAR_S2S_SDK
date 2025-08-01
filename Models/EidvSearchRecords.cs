using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EidvSearchRecords")]
public class EidvSearchRecords
{
    [XmlElement("SearchRecord")]
    public List<EidvSearchRecord> SearchRecord { get; set; }

}
}