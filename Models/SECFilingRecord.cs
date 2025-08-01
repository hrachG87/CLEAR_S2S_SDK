using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SECFilingRecord")]
public class SECFilingRecord
{
    [XmlElement("SECFinancialFilings")]
    public List<SECInfo> SECFinancialFilings { get; set; }

}
}