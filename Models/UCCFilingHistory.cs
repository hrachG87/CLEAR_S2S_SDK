using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("UCCFilingHistory")]
public class UCCFilingHistory
{
    [XmlElement("uccfilingInfo")]
    public UCCFilingInfo uccfilingInfo { get; set; }

}
}