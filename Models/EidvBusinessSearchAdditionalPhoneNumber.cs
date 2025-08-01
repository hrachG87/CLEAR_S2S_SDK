using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EidvBusinessSearchAdditionalPhoneNumber")]
public class EidvBusinessSearchAdditionalPhoneNumber
{
    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("Source")]
    public List<string> Source { get; set; }

    [XmlElement("DocumentIdentifierInfo")]
    public List<EidvBusinessSearchDocumentIdentifierInfo> DocumentIdentifierInfo { get; set; }

}
}