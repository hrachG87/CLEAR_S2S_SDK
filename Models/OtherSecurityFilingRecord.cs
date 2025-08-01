using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("OtherSecurityFilingRecord")]
public class OtherSecurityFilingRecord
{
    [XmlElement("OtherSecuritiesFilings")]
    public List<SECInfo> OtherSecuritiesFilings { get; set; }

}
}