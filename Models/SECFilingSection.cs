using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SECFilingSection")]
public class SECFilingSection
{
    [XmlElement("SECFilingRecord")]
    public List<SECFilingRecord> SECFilingRecord { get; set; }

}
}