using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FcraSection")]
public class FcraSection
{
    [XmlElement("DisclaimerText")]
    public string DisclaimerText { get; set; }

}
}