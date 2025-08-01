using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("UCCInfo")]
public class UCCInfo
{
    [XmlElement("UCCFilingNumber")]
    public string UCCFilingNumber { get; set; }

    [XmlElement("UCCFilingDate")]
    public string UCCFilingDate { get; set; }

}
}