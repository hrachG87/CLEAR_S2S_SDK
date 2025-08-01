using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformPersonWebResult")]
public class RiskInformPersonWebResult
{
    [XmlElement("RecordId")]
    public string RecordId { get; set; }

    [XmlElement("WebRecord")]
    public WebResult WebRecord { get; set; }

}
}