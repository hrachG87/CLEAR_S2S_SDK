using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("EidvPersonSearchAdditionalPhoneNumbers")]
public class EidvPersonSearchAdditionalPhoneNumbers
{
    [XmlElement("AdditionalPhoneNumber")]
    public List<EidvPersonSearchAdditionalPhoneNumber> AdditionalPhoneNumber { get; set; }
}
