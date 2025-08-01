using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EidvBusinessSearchAdditionalPhoneNumbers")]
public class EidvBusinessSearchAdditionalPhoneNumbers
{
    [XmlElement("AdditionalPhoneNumber")]
    public List<EidvBusinessSearchAdditionalPhoneNumber> AdditionalPhoneNumber { get; set; }

}
}