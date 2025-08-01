using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformBusinessWebResult")]
public class RiskInformBusinessWebResult
{
    [XmlElement("RecordId")]
    public string RecordId { get; set; }

    [XmlElement("WebRecord")]
    public WebResult WebRecord { get; set; }

}
}