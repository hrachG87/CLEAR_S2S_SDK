using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RawAdditionalInfoList")]
public class RawAdditionalInfoList
{
    [XmlElement("RawAdditionalInfo")]
    public List<RawAdditionalInfo> RawAdditionalInfo { get; set; }

}
}