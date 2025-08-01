using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EidvPersonSearchAdditionalPhoneNumbers")]
public class EidvPersonSearchAdditionalPhoneNumbers
{
    [XmlElement("AdditionalPhoneNumber")]
    public List<EidvPersonSearchAdditionalPhoneNumber> AdditionalPhoneNumber { get; set; }

}
}