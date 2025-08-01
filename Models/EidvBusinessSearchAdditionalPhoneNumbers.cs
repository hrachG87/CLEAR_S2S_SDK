using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("EidvBusinessSearchAdditionalPhoneNumbers")]
public class EidvBusinessSearchAdditionalPhoneNumbers
{
    [XmlElement("AdditionalPhoneNumber")]
    public List<EidvBusinessSearchAdditionalPhoneNumber> AdditionalPhoneNumber { get; set; }
}
